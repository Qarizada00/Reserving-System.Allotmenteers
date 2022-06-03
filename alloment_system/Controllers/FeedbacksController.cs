using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alloment_system.DBModel;
namespace alloment_system.Controllers
{
    public class FeedbacksController : Controller
    {
        // GET: Feedbacks
        public ActionResult Feedbacks()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedbacks(FormCollection form)

        {
           
            UserDBEntities6 db = new UserDBEntities6();
            Feedbacks model = new DBModel.Feedbacks();
            model.Email = form["Email"];
            model.Message = form["Message"];
            db.Feedbacks.Add(model);
            db.SaveChanges(); 
            return View();
        }
    }
} 