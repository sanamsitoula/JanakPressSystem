
using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _db;
        private readonly DbSet<T> dbSet;
        public Repository(ApplicationDBContext db) {
            _db = db;
            if (db == null)
            {
                throw new ArgumentNullException(nameof(db), "DbContext is null.");
            }
            this.dbSet=_db.Set<T>();
            //_db.Categories ==dbset;
           

        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T? GetFirstOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query=query.Where(filter);
            return query.FirstOrDefault();
        }
     

        public IQueryable<T> GetAll()
        {
            if (dbSet == null)
            {
                // Log an error message indicating that dbSet is null
                // Logging code here...

                // Return an empty enumerable
                return null;
            }
          //  return JsonConvert.DeserializeObject<List<T>>(dbSet.ToList());
            return dbSet.AsQueryable();
        }

        public IQueryable<T> GetAllThroughParam(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return (IQueryable<T>)query.ToList();
        }


        public void Remove(T entity)
        {
           dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);

        }
    }
}
