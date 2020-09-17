using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var signupVms = new List<SignUpVm>();

                foreach (var signup in signups)
                {
                    var signUpVm = new SignUpVm();
                    signUpVm.Id = signup.Id;
                    signUpVm.FirstName = signup.FirstName;
                    signUpVm.LastName = signup.LastName;
                    signUpVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signUpVm);
                }
                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}