using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudeApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employe
        public ActionResult Add()
        {
            return View();
        }
        
        public ActionResult EmpDetails()
        {
            UspRoughEntities1 r = new UspRoughEntities1();
            var data = r.Usp_EmpList().ToList();
            ViewBag.userdetails = data;
            return View();
        }
    }
}