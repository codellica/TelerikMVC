using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codellica.Lib.DAL.Model;
using Codellica.Lib.DAL.Repositories.Base;
using System.Configuration;

namespace Codellica.Lib.DAL.UnitsOfWork
{
    /// <summary>
    /// EF implementation of IUnitOfWork
    /// </summary>
    public class SqlUnitOfWork : IUnitOfWork, IDisposable
    {
        private NorthwindModel _ctx;

        #region [-- Repositories --]
        private IRepository<Category> _Categories;
        public IRepository<Category> Categories
        {
            get
            {
                if (_Categories == null)
                {
                    _Categories = new SqlRepository<Category>(_ctx);
                }
                return _Categories;
            }
        }

        private IRepository<Customer> _Customers;
        public IRepository<Customer> Customers
        {
            get
            {
                if (_Customers == null)
                {
                    _Customers = new SqlRepository<Customer>(_ctx);
                }
                return _Customers;
            }
        }

        private IRepository<Product> _Products;
        public IRepository<Product> Products
        {
            get
            {
                if (_Products == null)
                {
                    _Products = new SqlRepository<Product>(_ctx);
                }
                return _Products;
            }
        }
        #endregion


        public SqlUnitOfWork(string connextionstringName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[connextionstringName].ConnectionString;
            _ctx = new NorthwindModel(connectionString);
            _ctx.Configuration.LazyLoadingEnabled = true;
        }

        public void Commit()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            if(_ctx != null)
                _ctx.Dispose();
        }
    }
}
