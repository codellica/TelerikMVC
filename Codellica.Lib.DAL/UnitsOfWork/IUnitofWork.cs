using Codellica.Lib.DAL.Model;
using Codellica.Lib.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codellica.Lib.DAL.UnitsOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IRepository<Customer> Customers { get; }
        IRepository<Product> Products { get; }
        void Commit();
    }
}
