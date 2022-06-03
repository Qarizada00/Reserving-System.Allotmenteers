using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using alloment_system.DBModel;
using alloment_system.Models;

namespace alloment_system.Controllers
{
    public class ItemEditController : Controller
    {




        public ActionResult ItemEdit()
        {
            UserDBEntities6 Products = new UserDBEntities6();
            {
                var list = from x in Products.Products select x;
                return View(list);
            }
        }
        public ActionResult Details(int id)
        {
            using (UserDBEntities6 dbmodel = new UserDBEntities6())
            {
                return View(dbmodel.Products.Where(x => x.P_id == id).FirstOrDefault());
            }
        }












        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            Products info = new Products();

            string fileName = Path.GetFileNameWithoutExtension(product.p_path.FileName);
            string extension = Path.GetExtension(product.p_path.FileName);
            fileName = fileName + extension;
            product.P_image = "~/images/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/images/"), fileName);
            product.p_path.SaveAs(fileName);


            info.P_name = product.P_name;
            info.P_image = product.P_image;
            info.P_price = product.P_price;



            using (UserDBEntities6 dbmodel = new UserDBEntities6())
            {

                dbmodel.Products.Add(info);
                dbmodel.SaveChanges();
            }

            ModelState.Clear();
            return View();
        }


    
    









        public ActionResult Edit(int id)
        {   using (UserDBEntities6 dbmodel = new UserDBEntities6())
            {
                return View(dbmodel.Products.Where(x => x.P_id == id).FirstOrDefault());
            }
        }




        [HttpPost]
        public ActionResult Edit( Products Product)
        {
            try
            {
                using (UserDBEntities6 dbmodel = new UserDBEntities6())
                {
                    dbmodel.Entry(Product).State = EntityState.Modified;
                    dbmodel.SaveChanges();

                }
                return RedirectToAction("ItemEdit");
            }
            catch
            {
                return View();
            }
        }









        public ActionResult Delete(int id)
        {
            using (UserDBEntities6 dbmodel = new UserDBEntities6())
            {
                return View(dbmodel.Products.Where(x => x.P_id == id).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (UserDBEntities6 dbmodel = new UserDBEntities6())
                {
                    Products product = dbmodel.Products.Where(x => x.P_id == id).FirstOrDefault();
                    dbmodel.Products.Remove(product);
                    dbmodel.SaveChanges();

                }

                return RedirectToAction("Delete");
            }
            catch
            {
                return View();
            }
        }
    }
}
