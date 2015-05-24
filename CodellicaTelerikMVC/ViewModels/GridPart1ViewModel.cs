using Codellica.Lib.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodellicaTelerikMVC.ViewModels
{
    public class GridPart1ViewModel
    {
        public ICollection<CategoryViewModel> Categories { get; set;}

        public GridPart1ViewModel()
        {
            Categories = new HashSet<CategoryViewModel>();
        }
    }

    public class CategoryViewModel : Category
    {

    }
}