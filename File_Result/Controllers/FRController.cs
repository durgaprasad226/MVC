using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace File_Result.Controllers
{
    public class FRController : Controller
    {
        public FileResult Progress()
        {
            return File("~/Content/Progress.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
        public FileResult Schedule()
        {
            return File("~/Content/Schedule.xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }
    }
}