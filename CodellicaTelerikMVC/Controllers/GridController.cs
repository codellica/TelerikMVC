using Codellica.Lib.DAL.UnitsOfWork;
using CodellicaTelerikMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace CodellicaTelerikMVC.Controllers
{
    public class GridController : Controller
    {
        private IUnitOfWork _uow;

        public GridController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GridPart1()
        {
            ViewBag.Title = "Grid Part I";

            var categories = _uow.Categories.All.ToList();

            GridPart1ViewModel model = new GridPart1ViewModel();

            foreach (var category in categories)
            {
                model.Categories.Add(new CategoryViewModel 
                { 
                    CategoryID = category.CategoryID, 
                    CategoryName = category.CategoryName, 
                    Description = category.Description, 
                    Picture = category.Picture 
                });
            }

            return View(model);
        }

        public ActionResult GridPart2()
        {
            ViewBag.Title = "Grid Part II";
            return View();
        }

        public ActionResult GetCategories([DataSourceRequest]DataSourceRequest request)
        {
            var categories = _uow.Categories.All.ToList();

            ICollection<CategoryViewModel> model = new HashSet<CategoryViewModel>();

            foreach (var category in categories)
            {
                model.Add(new CategoryViewModel(category));
            }

            return Json(model.ToDataSourceResult(request));
        }

        public ActionResult GetCategoryProducts([DataSourceRequest]DataSourceRequest request, int categoryID)
        {
            var products = _uow.Products.All.Where(p => p.CategoryID == categoryID);

            ICollection<ProductViewModel> model = new HashSet<ProductViewModel>();

            foreach (var product in products)
            {
                model.Add(new ProductViewModel(product));
            }

            return Json(model.ToDataSourceResult(request));
        }

        protected override void Dispose(bool disposing)
        {
            _uow.Dispose();
            base.Dispose(disposing);
        }
    }
}