using RPCPullPush.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPCPullPush.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Repository repository = new Repository();
            List<Employee> emp = repository.GetAllMessages();

            return View();
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetMessages()
        {
            List<Employee> messages = new List<Employee>();
            Repository r = new Repository();
            messages = r.GetAllMessages();
            return Json(messages, JsonRequestBehavior.AllowGet);
        }
    }
}