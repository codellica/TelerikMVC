using Codellica.Lib.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codellica.Lib.DAL.Repositories.Base
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IQueryable<Category> GetCategoriesWithProducts();
    }
}
