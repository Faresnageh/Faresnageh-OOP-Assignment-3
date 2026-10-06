namespace Generics
{
    public class Student : IHasId
    {
        public Student(string name, int id)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            Name = name;
            Id = id;
        }

        public string Name { get; }
        public int Id { get; }
    }
}
