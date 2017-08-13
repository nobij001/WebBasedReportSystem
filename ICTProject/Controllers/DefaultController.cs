using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// JORDAN -- Made this controller to test travelling to new View. (views should be in Default folder)
// So far nothing working.
namespace ICTProject.Controllers
{
    public class DefaultController : Controller
    {

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}