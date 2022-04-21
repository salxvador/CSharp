using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //Lambda Syntax:
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                // LINQ syntax does the same thing as above:
                //var signups = (from c in db.SignUps
                //               where c.Removed == null
                //               select c).ToList();
                List<SignupVM> signupVMs = new List<SignupVM>();
                foreach (var signup in signups)
                {
                    var signupVM = new SignupVM();
                    signupVM.Id = signup.Id;
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.Email;
                    signupVMs.Add(signupVM);
                }
                return View(signupVMs);
            }

            // REPLACED WITH ENTITY FWK above
            //string qString = @"SELECT Id, FirstName, LastName, Email, SocialSecurityNumber FROM SignUps";
            //List<NewsLetterSignUp> signups = new List<NewsLetterSignUp>();

            //using (SqlConnection cxn = new SqlConnection(cxnString))
            //{
            //    SqlCommand cmd = new SqlCommand(qString, cxn);
            //    cxn.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsLetterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["Email"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        signups.Add(signup);
            //    }
            //}
        }

        public ActionResult Unsubscribe(int id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}