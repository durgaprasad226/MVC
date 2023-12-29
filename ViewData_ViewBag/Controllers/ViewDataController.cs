using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewData_ViewBag.Controllers
{
    public class ViewDataController : Controller
    {
        public ViewResult Index()
        {
            //string name = "Viraaj";
            ViewData["name"] = "My name is Viraaj";
            ViewData.Add("age", 9);
            ViewData["Hobbies"] = new List<string>
            {
                "Eating",
                "Sleeping",
                "Playing"
            };
            return View();
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}