using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (!(Session["UserInfo"] is Vm_UserInfo vuser))
            {
                return RedirectToAction("Index", "Authentication");
            }



            return View();
        }
    }
}