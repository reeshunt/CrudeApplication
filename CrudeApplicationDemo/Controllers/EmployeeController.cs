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
    }
}