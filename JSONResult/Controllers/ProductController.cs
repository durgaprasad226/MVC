using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JSONResult.Models;

namespace JSONResult.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Chocolates", Price=30},
            new Product{Id=2, Name="Biscuits", Price = 80},
        };

        public JsonResult ProductsData()
        {
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}