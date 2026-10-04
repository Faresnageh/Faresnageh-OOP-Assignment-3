namespace Generics
{
    public class StudentStore
    {
        private List<Student> _students = new List<Student>();
        public void Add(Student student)
        {
            if (student is null)
                return;
            _students.Add(student);
        }
        public List<Student> GetAll()
        {
            return _students;
        }
        public Student? GetById(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            foreach (var student in _students)
            {
                if (student.Id == id)
                    return student;
            }
            return null;
        }
        public void Remove(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            foreach (var student in _students)
            {
                if (student.Id == id)
                    _students.Remove(student);
                return;
            }
        }
    }
}
