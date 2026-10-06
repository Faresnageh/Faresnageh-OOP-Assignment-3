namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store<Student> students = new Store<Student>();
            var student01 = new Student("Fares", 1);
            var student02 = new Student("Nageh", 2);
            var student03 = new Student("Sameh", 3);
            var student04 = new Student("Ali", 4);
            var student05 = new Student("Assem", 5);

            students.Add(student01);
            students.Add(student02);
            students.Add(student03);
            students.Add(student04);
            students.Add(student05);

            Store<Course> courses = new Store<Course>();
            var course01 = new Course(1, "C#", 1000m);
            var course02 = new Course(2, "C", 2000m);
            var course03 = new Course(3, "C++", 3000m);

            courses.Add(course01);
            courses.Add(course02);
            courses.Add(course03);

            var student = students.GetById(1);
            var course = courses.GetById(1);

            Console.WriteLine($"StudentName:{student?.Name}, StudentId:{student?.Id}");
            Console.WriteLine($"CourseId:{course?.Id}, CourseTitle:{course?.Title}, CoursePrice:{course?.Price}");

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                students.Add(new Student("Fares", 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine();
            Console.WriteLine("Page 2:");
            IEnumerable<Student> page = students.GetAll().Values.Page(2, 2);
            foreach (Student item in page)
            {
                Console.WriteLine($"{item.Id}, {item.Name}");
            }

            Console.WriteLine();
            List<Course> courseList = new List<Course>()
            {
                course01,
                course02,
                course03
            };
            Course? foundCourse = courseList.FindById(2);
            Console.WriteLine($"Found Course: CourseId:{foundCourse?.Id},  CourseTitle:{foundCourse?.Title}");



            //Store<string> stringStore = new Store<string>();
        }
    }
}
