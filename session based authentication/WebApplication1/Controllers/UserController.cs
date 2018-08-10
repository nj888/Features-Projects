using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private AuthDBContext db = new AuthDBContext();

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            //logic here 
            if (ModelState.IsValid)
            {
                //check if the user is present or not 
                var tmp = db.UserTable.Where(p => p.Username == model.UserName).ToList();
                if (tmp?.Count()!=0)
                {
                    return View(model);
                }

                UserInformation user = new UserInformation() {
                    Name = model.Name,
                    Password = model.Password,
                    Username = model.UserName
                };

                try
                {
                    db.UserTable.Add(user);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return View(model);
                    
                }

                Session["Loggedin"] = true;
                Session["Username"] = model.UserName;

            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Login (LoginViewModel model)
        {
            //logic here 



            return View();
        }

    }
}