namespace Generics
{
    public class Store<T> where T : IHasId
    {
        private List<T> _stores = new List<T>();

        public void Add(T item)
        {
            if (item is null)
                return;

            _stores.Add(item);
        }

        public List<T> GetAll()
        {
            return _stores;
        }

        public T? GetById(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);

            foreach (var item in _stores)
            {
                if (item.Id == id)
                    return item;
            }

            return default;
        }

        public void Remove(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);

            for (int i = 0; i < _stores.Count; i++)
            {
                if (_stores[i].Id == id)
                {
                    _stores.RemoveAt(i);
                    return;
                }
            }
        }
    }
}