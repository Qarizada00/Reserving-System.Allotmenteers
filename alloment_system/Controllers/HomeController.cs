using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alloment_system.DBModel;
namespace alloment_system.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A journey That Started In 1899.";
            UserDBEntities6 branches = new UserDBEntities6();
            var list = from x in branches.Branches select x;
            return View(list);
        }

     
   
    }

} 