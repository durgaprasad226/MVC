using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViews2.Models;

namespace PartialViews2.Controllers
{
    public class PlacesController : Controller
    {
        List<Places> places = new List<Places>()
        {
            new Places{Id=1,Name="Birla Mandir",Location="Assembly",Image="~/Images/BirlaMandir.jpg"},
            new Places{Id=2,Name="Charminar",Location="Hyderabad",Image="~/Images/Charminar.jpg"},
            new Places{Id=3,Name="Golconda",Location="Hyderabad",Image="~/Images/Golconda.jpg"},
            new Places{Id=4,Name="India Gate",Location="Delhi",Image="~/Images/IndiaGate.jpg"},
            new Places{Id=5,Name="Lotus Temple",Location="New Delhi",Image="~/Images/LotusTemple.jpg"},
            new Places{Id=6,Name="Taj Mahal",Location="Agra",Image="~/Images/TajMahal.jpg"}
        };

        public PartialViewResult ProtoType()
        {
            return PartialView();
        }

        public ActionResult Index()
        {
            return View(places);
        }
    }
}