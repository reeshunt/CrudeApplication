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
        public JsonResult AddEmployee(Tbl_Emp dataObj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UspRoughEntities1 dbContext = new UspRoughEntities1();
                    dbContext.Usp_Emp(dataObj.EmployeeName, dataObj.EmpId, dataObj.Designation, dataObj.DateOfBirth, dataObj.DateOfRetirement, dataObj.ContactNumber, dataObj.Address, dataObj.FileUpload, dataObj.PhotoUpload);
                    dbContext.SaveChanges();
                    return Json(new { msg = "success" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception Ex)
                {
                    return Json(new { msg = "error", errorMsg = Ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { msg = "error", errorMsg = "Enter Valid Details" }, JsonRequestBehavior.AllowGet);
            }
            
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