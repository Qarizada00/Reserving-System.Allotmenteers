using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alloment_system.DBModel;
using alloment_system.Models;
namespace alloment_system.Controllers
{
    public class ReservedsController : Controller
    {


        UserDBEntities6 user = new UserDBEntities6();
        // GET: Employee
        public ActionResult Reserveds()
        {
            var list = from x in user.Reservation select x;
            return View(list);
        }

    }
}