using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;
using WebUI.ViewModels;
using System.Data.Entity;

namespace WebUI.Controllers
{
    public class PaymentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Payment/
        public ActionResult Receive()
        {
            ReceivePaymentViewModel model = new ReceivePaymentViewModel();
            var currentUser = db.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault();
            var account = db.Accounts.Include(c => c.AccountLabel).Where(a=>a.MemberID==currentUser.Id).FirstOrDefault();
            if (account == null)
                return HttpNotFound();
            if(account.PaymentID==0 && account.AccountLabelID!=0)
            {
                model.AccountLevel = account.AccountLabel;
                model.Amount = account.AccountLabel.Amount;
                model.PaymentMethod = "Paypal";
               
            }
            else
            {

            }
            return View(model);
        }
	}
}