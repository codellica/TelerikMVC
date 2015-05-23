using Codellica.Lib.DAL.Model;
using Codellica.Lib.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codellica.Lib.DAL.Repositories
{
    public class CategorySqlRepository : SqlRepository<Category>
    {
        public CategorySqlRepository(DbContext context)
            : base(context)
        {

        }
    }
}
