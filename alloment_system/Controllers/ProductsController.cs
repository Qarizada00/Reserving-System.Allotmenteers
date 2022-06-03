using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alloment_system.DBModel;
using alloment_system.Models;
namespace alloment_system.Controllers
{
   public class ProductsController : Controller
    {


        UserDBEntities6 Products = new UserDBEntities6();
        // GET: Employee
        public ActionResult Items()
        {
            var list = from x in Products.Products select x;
            return View(list);
        }





        public ActionResult Details(int id)
        {
            using (UserDBEntities6 dbmodel = new UserDBEntities6())
            {
                return View(dbmodel.Products.Where(x => x.P_id == id).FirstOrDefault());
            }
        }








        public ActionResult Reserve(string Name)

            
        {   UserDBEntities6 db = new UserDBEntities6();
            Products A = db.Products.Where(x => x.P_name == Name).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Reserve(Reservation form)

        {

            UserDBEntities6 db = new UserDBEntities6();
            Reservation model = new Reservation();
            model.Id = form.Id;
            model.Product = "Product";
            model.Name = form.Name;
            model.Email = form.Email;
            model.Date = form.Date;
            db.Reservation.Add(model);
            db.SaveChanges();
            return View();
        }


    }
}




