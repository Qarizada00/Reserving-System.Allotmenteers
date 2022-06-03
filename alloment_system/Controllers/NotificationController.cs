using alloment_system.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace alloment_system.Controllers
{
    public class NotificationController : Controller
    {
        UserDBEntities6 db = new UserDBEntities6();
        public ActionResult Notification()
            
        {
            var list = from x in db.Notify select x;
            return View(list);
        }
    }
}