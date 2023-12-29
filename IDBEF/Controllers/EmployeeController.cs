using IDBEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace IDBEF.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext ec=new EmployeeContext();
        public ViewResult Index()
        {
            return View(ec.Employees.ToList());
        }

        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Please provide Employee ID");
            }
            Employee emp=ec.Employees.Find(id);
            if(emp==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, $"Employee not found with the given Id {id}");
            }
            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {                                                           //using FormCollection
            Employee emp = new Employee();
            emp.Name = formCollection["Name"];
            emp.Dept = formCollection["Dept"];
            emp.Salary = int.Parse(formCollection["Salary"]);
            ec.Employees.Add(emp);
            ec.SaveChanges();
            return RedirectToAction("Index");
        }*/

        /*[HttpPost]
        public ActionResult Create(string Name, string Dept, int Salary)
        {
            Employee emp=new Employee();                            //using FormControls
            emp.Name = Name;
            emp.Dept = Dept;
            emp.Salary = Salary;
            ec.Employees.Add(emp);
            ec.SaveChanges();
            return RedirectToAction("Index");
        }*/

        /*[HttpPost]
        public ActionResult Create(Employee emp)
        {                                                           //using Model
            ec.Employees.Add(emp);
            ec.SaveChanges();
            return RedirectToAction("Index");
        }*/

        /*[HttpPost]
        [ActionName("Create")]
        public ActionResult AddProduct()
        {                                                           //using UpdateModel()
            Employee emp=new Employee();
            UpdateModel(emp);
            ec.Employees.Add(emp);
            ec.SaveChanges();
            return RedirectToAction("Index");
        }*/

        [HttpPost]
        [ActionName("Create")]
        public ActionResult AddProduct()
        {                                                           //using TryUpdateModel()
            if (ModelState.IsValid)
            {
                Employee emp = new Employee();
                TryUpdateModel(emp);
                ec.Employees.Add(emp);
                ec.SaveChanges();  
            }
            return RedirectToAction("Index");
        }
    }
}