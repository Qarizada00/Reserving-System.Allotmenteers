using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alloment_system.DBModel;

namespace alloment_system.Controllers
{
    public class UserController : Controller
    {
        UserDBEntities6 user = new UserDBEntities6();
        // GET: Employee
        public ActionResult User()
        {
            var list = from x in user.User select x;
            return View(list);
        }
    }
}