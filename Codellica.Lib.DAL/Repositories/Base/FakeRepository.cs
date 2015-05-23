using Codellica.Lib.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codellica.Lib.DAL.Repositories.Base
{
    public class FakeRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected HashSet<T> _set;
        protected IQueryable<T> _queryableSet;

        public FakeRepository(IEnumerable<T> entities)
        {
            _set = new HashSet<T>();

            foreach (var entity in entities)
            {
                _set.Add(entity);
            }

            _queryableSet = _set.AsQueryable();
        }

        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public IQueryable<T> All
        {
            get
            {
                return _queryableSet;
            }
        }

        public IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _queryableSet.Where(predicate);
        }

        public T FindById(int id)
        {
            return _set.Single(e => e.Id == id);
        }

        public void Remove(T entity)
        {
            _set.Remove(entity);
        }
    }
}
