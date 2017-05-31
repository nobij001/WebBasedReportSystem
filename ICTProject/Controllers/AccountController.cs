using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICTProject.Models.DBC;
using ICTProject.Data;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace ICTProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User account)
        {
            if(ModelState.IsValid)
            {
                using (DbcContext db = new DbcContext())
                {
                    db.Users.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " successfully registered.";
            }
            return RedirectToAction("Login");
        }

        //Logging in.
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User l, string ReturnUrl = "")
        {
            using(DbcContext db = new DbcContext())
            {
                var user = db.Users.Where(a => a.Username.Equals(l.Username) && a.Password.Equals(l.Password)).FirstOrDefault();
                if(user != null)
                {
                    FormsAuthentication.SetAuthCookie(l.Username, l.RememberMe);
                    if(Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("LoggedIn");
                    }
                }
            }
            ModelState.Remove("Password");
            return View();
        }

        [Authorize]
        public ActionResult LoggedIn()
        {
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}