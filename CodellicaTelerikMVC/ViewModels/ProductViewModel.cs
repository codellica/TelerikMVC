using Codellica.Lib.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodellicaTelerikMVC.ViewModels
{
    public class ProductViewModel : Product
    {
        public ProductViewModel()
        {

        }

        public ProductViewModel(Product product)
        {
            this.CategoryID = product.CategoryID;
            this.Discontinued = product.Discontinued;
            this.ProductID = product.ProductID;
            this.ProductName = product.ProductName;
            this.QuantityPerUnit = product.QuantityPerUnit;
            this.ReorderLevel = product.ReorderLevel;
            this.UnitPrice = product.UnitPrice;
            this.UnitsInStock = product.UnitsInStock;
            this.UnitsOnOrder = product.UnitsOnOrder;
        }
    }
}