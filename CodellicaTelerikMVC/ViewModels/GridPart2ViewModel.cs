using Codellica.Lib.DAL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CodellicaTelerikMVC.ViewModels
{
    public class GridPart2ViewModel
    {
        public ICollection<CategoryViewModel> Categories { get; set;}

        public GridPart2ViewModel()
        {
            Categories = new HashSet<CategoryViewModel>();
        }
    }
}