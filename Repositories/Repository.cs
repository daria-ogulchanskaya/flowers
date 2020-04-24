using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Flowers.Repositories
{
    public class Repository<T> : IRepository<T> 
        where T : class, IEntity
    {
        private DatabaseContext _database;
        private DbSet<T> _set;

        public Repository(DatabaseContext databaseContext, DbSet<T> set)
        {
            _database = databaseContext;
            _set = set;
        }

        public IEnumerable<T> All() =>
            _set;

        public T Get(int id) =>
            _set.FirstOrDefault(x => x.Id == id);

        public bool Add(T item)
        {
            if (item != null)
            {
                _set.Add(item);
                _database.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool Remove(int id)
        {
            var item = _set.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return false;

            _set.Remove(item);
            _database.SaveChanges();

            return true;
        }

        public bool Update(T item)
        {
            if (item == null)
                return false;

            var old = _set.FirstOrDefault(x => x.Id == item.Id);
            if (old == null)
                return false;

            _set.Remove(old);
            _set.Add(item);

            _database.SaveChanges();

            return true;
        }
    }
}
