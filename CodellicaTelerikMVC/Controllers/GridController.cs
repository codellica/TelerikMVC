using Codellica.Lib.DAL.UnitsOfWork;
using CodellicaTelerikMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        protected override void Dispose(bool disposing)
        {
            _uow.Dispose();
            base.Dispose(disposing);
        }
    }
}