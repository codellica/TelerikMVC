using Codellica.Lib.DAL.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
        public string Image64 
        { 
            get
            {
                string result = String.Empty;

                if (Picture != null)
                {
                    MemoryStream ms = new MemoryStream();
                    ms.Write(Picture, 78, Picture.Length - 78); // strip out 78 byte OLE header
                    result = Convert.ToBase64String(ms.ToArray());
                }

                return result;
            }
        }       
    }
}