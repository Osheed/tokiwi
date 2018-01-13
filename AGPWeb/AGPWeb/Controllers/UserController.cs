using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agp___Agile_Project.Models;

namespace Agp___Agile_Project.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Connect()
        {
            ViewData["Message"] = "Login";
            return View();
        }

        public ActionResult ErrorLogin()
        {
            ViewData["Message"] = "Erron on Login";
            return View("Connect");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Connect(UserModel user)
        {
            string email = user.Email;
            string pass = user.Password;

            if (ModelState.IsValid)
            {
                ViewBag.Password = user.Password;
                ViewBag.Email = user.Email;
            }
            else
                return View(user);

            var employe = from e in GetEmployee()
                            where e.Email == email  && e.Password == pass
                            select e;
            if(employe.Count() == 1)
                return RedirectToAction("Index", "Home");
            else
                return RedirectToAction("ErrorLogin");
        }

        [NonAction]
        public List<UserModel> GetEmployee()
        {
            return new List<UserModel>{
            new UserModel{
               ID = 1,
               Name = "Tiago",
               Password = "1234",
               Email = "tiago@agp.ch"
            },

            new UserModel{
               ID = 2,
               Name = "Christian",
               Password = "4321",
               Email = "christian@agp.ch"
            }
         };
        }

    }
}