namespace Generics
{
    public class CourseStore
    {
        private List<Course> _courses = new List<Course>();
        public void Add(Course course)
        {
            if (course is null)
                return;
            _courses.Add(course);
        }
        public List<Course> GetAll()
        {
            return _courses;
        }
        public Course? GetById(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            foreach (var course in _courses)
            {
                if (course.Id == id)
                    return course;
            }
            return null;
        }
        public void Remove(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            for (int i = 0; i < _courses.Count; i++)
            {
                if (_courses[i].Id == id)
                {
                    _courses.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
