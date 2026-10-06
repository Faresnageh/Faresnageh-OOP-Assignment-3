namespace Generics
{
    public class Course : IHasId
    {
        public Course(int id, string title, decimal price)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title));
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; }
        public string Title { get; }
        public decimal Price { get; }
    }
}
