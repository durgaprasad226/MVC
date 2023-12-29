using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using STModelViews.Models;

namespace STModelViews.Controllers
{
    public class ProductsController : Controller
    {
        ProductsData pd= new ProductsData();
        public ViewResult Index()
        {
            return View(pd.ProductsList.ToList());
        }
        public ViewResult Details(int id)
        {
            Product product = pd.ProductsList.Single(x => x.ProductId == id);
            return View(product);
        }
    }
}