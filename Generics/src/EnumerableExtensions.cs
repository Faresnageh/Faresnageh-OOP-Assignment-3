using System.Runtime.CompilerServices;

namespace Generics
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(this IEnumerable<T> values, int pageNumber, int pageSize)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(pageNumber);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(pageSize);
            int skip = (pageNumber - 1) * pageSize;
            int index = 0;
            int taken = 0;

            foreach (T item in values)
            {
                if (index >= skip)
                {
                    yield return item;
                    taken++;
                }
                if (taken == pageSize)
                    yield break;
                index++;
            }
        }
        public static T? FindById<T>(this IEnumerable<T> values,int id) where T : IHasId
        {
            foreach (var item in values)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default;
        }
        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> values) where T : IHasId
        {
            Dictionary<int, T> valuePairs = new Dictionary<int, T>();
            foreach (var item in values)
            {
                valuePairs.Add(item.Id, item);
            }
            return valuePairs;
        }
    }
}
