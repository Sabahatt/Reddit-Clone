using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redditclone.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup()
        {
            //return Json("Signup");
            string output = "Signup";
            return Json(output, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Login()
        {
            string output = "Login";
            return Json(output, JsonRequestBehavior.AllowGet);
        }
    }
}