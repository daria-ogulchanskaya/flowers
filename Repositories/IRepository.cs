using System.Collections.Generic;

namespace Flowers.Repositories
{
    public interface IRepository<T> where T : class
    {
        bool Add(T item);
        bool Remove(int id);

        bool Update(T item);

        T Get(int id);

        IEnumerable<T> All();
    }
}
