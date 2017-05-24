using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICTProject.Models.DBC;
using ICTProject.Data;

namespace ICTProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

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
            return View();
        }

        //Logging in.
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User account)
        {
            using(DbcContext db = new DbcContext())
            {
                var usr = db.Users.Where(u => u.Username == account.Username && u.Password == account.Password).FirstOrDefault();
                if(usr != null)
                {
                    Session["UserID"] = usr.UserId.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorrect.");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
                return View();
            else
                return RedirectToAction("Login");
        }
    }
}