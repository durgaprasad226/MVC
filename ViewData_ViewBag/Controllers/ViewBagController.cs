using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewData_ViewBag.Controllers
{
    public class ViewBagController : Controller
    {
        public ViewResult VBIndex()
        {
            ViewBag.Name = "My name is Vinishka from ViewBag";
            ViewBag.Age = "I'm 2 years old";
            ViewBag.Hobbies = new List<string>
            {
                "Crying",
                "Sleeping"
            };
            return View();
        }
    }
}