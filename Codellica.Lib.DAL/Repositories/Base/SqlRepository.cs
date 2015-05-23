using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codellica.Lib.DAL.Repositories.Base
{
    public class SqlRepository<T> : IRepository<T>
                             where T : class
    {
        protected DbSet<T> _set;

        public SqlRepository(DbContext context)
        {
            _set = context.Set<T>();
        }

        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public void Remove(T entity)
        {
            _set.Remove(entity);
        }

        public IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _set.Where(predicate);
        }
        

        public IQueryable<T> All
        {
            get
            {
                return _set;
            }
        }

        public T FindById(int id)
        {
            return _set.Find(id);
        }
            

    }
}
