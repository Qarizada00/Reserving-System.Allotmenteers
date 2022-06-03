using alloment_system.DBModel;
using System.Linq;
using System.Web.Mvc;
namespace alloment_system.Controllers
{
    public class MessagesController : Controller
    {
      


        UserDBEntities6 Feedbacks = new UserDBEntities6();
        // GET: Employee
        public ActionResult Messages()
        {
            var list = from x in Feedbacks.Feedbacks select x;
            return View(list);
        }
    }
}