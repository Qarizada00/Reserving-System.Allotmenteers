using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alloment_system.DBModel;

namespace alloment_system.Controllers
{
    public class EmployeeController : Controller
    {
        UserDBEntities6 dbo = new UserDBEntities6();
        // GET: Employee
        public ActionResult Employee1()
        {
            var list = from x in dbo.EmployeeView select x;
            return View(list);
        }
    }
}