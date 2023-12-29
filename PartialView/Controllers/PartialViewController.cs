using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class PartialViewController : Controller
    {
        public ViewResult PVIndex()
        {
            return View();
        }
        public PartialViewResult LoginPage()
        {
            return PartialView();
        }
    }
}