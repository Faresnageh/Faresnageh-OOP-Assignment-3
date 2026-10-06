namespace Generics
{
    public class Store<T> where T : IHasId
    {
        private Dictionary<int, T> _stores = new Dictionary<int, T>();

        public void Add(T item)
        {
            if (item is null)
                return;
            if (_stores.ContainsKey(item.Id))
            {
                throw new Exception("Id already exists");
            }
            _stores.Add(item.Id, item);
        }

        public IReadOnlyDictionary<int, T> GetAll()
        {
            return _stores;
        }

        public T? GetById(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);

            if (_stores.TryGetValue(id, out T? item))
            {
                return item;
            }
            return default;
        }

        public void Remove(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);

            _stores.Remove(id);
        }
    }
}