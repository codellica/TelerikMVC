using Codellica.Lib.DAL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CodellicaTelerikMVC.ViewModels
{
    public class CategoryViewModel : Category
    {
        private ICollection<ProductViewModel> _Products;

        public override ICollection<Product> Products
        {
            get
            {
                return _Products as ICollection<Product>;
            }
        }

        public CategoryViewModel()
        {

        }

        public CategoryViewModel(Category category)
        {
            CategoryID = category.CategoryID;
            CategoryName = category.CategoryName;
            Description = category.Description;
            Picture = category.Picture;

            if(category.Products != null)
            {
                _Products = new HashSet<ProductViewModel>();

                foreach (var product in category.Products)
                {
                    _Products.Add(new ProductViewModel(product));
                }
            }                       
        }

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