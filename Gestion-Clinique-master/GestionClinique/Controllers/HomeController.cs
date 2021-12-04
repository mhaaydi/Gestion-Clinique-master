using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security;
using System.Web.Razor;
using System.Web.Security;

namespace GestionClinique.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Responsable")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login model, string returnUrl)
        {
            DefaultConnectionEntities db = new DefaultConnectionEntities();
            var dataItem = db.AspNetUsers.Where(x => x.UserName == model.Username && x.PasswordHash == model.Password).FirstOrDefault();
            if (dataItem != null)
            {
                FormsAuthentication.SetAuthCookie(dataItem.Roles, false);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                         && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                ModelState.AddModelError("", "Non d'Utilisateur ou Mot de Passe invalide");
                return View();
            }
        }
        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }
    }
}