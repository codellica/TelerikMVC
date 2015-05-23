using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Codellica.Lib.DAL.Repositories.Base
{
    public interface IRepository<T>
    {
        void Add(T entity);
        System.Linq.IQueryable<T> All { get; }
        System.Linq.IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        T FindById(int id);
        void Remove(T entity);          
    }
}
