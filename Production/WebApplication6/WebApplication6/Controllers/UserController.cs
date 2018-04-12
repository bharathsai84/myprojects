using WebApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Security.Claims;
using System.Threading;
namespace WebApplication6.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            if (identity.Claims.Where(c => c.Type == ClaimTypes.Role)
                              .Select(c => c.Value).SingleOrDefault() == "Admin")
            {
                return RedirectToAction("Admin", "User");
            }
            else
            {
                return RedirectToAction("Users", "User");
            }
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Admin()
        {
            WebEntities db = new WebEntities();
            var list = db.UserAccounts.ToList();
            return View(list);
        }
        public ActionResult Alter()
        {
            return View();
        }
    }
}