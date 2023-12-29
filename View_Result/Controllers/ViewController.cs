using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View_Result.Controllers
{
    public class ViewController : Controller
    {
        public ViewResult Hello()
        {
            return View();
        }
    }
}