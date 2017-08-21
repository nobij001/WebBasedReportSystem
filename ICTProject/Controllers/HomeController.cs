using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICTProject.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous] // This is what you see when you're not logged in.
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestNav()
        {
            return View();
        }
    }
}