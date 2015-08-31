using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class BaseController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            string actionName = this.ControllerContext.RouteData.Values["action"].ToString();
            string controllerName = this.ControllerContext.RouteData.Values["controller"].ToString();

            var user = db.Users.Where(n => n.UserName == User.Identity.Name).FirstOrDefault();

            if (user == null)
            {
                filterContext.Result = new RedirectResult(Url.Action("Login", "Account")); 
            }

            var account = db.Accounts.Where(u => u.MemberID == user.Id).FirstOrDefault();
            
            if (account == null)
            {
                filterContext.Result = new RedirectResult(Url.Action("AccountSetup", "Account")); 
                
            }
            else
            {
                if (account.PaymentID == 0 && account.AccountLabelID!=0)
                    filterContext.Result = new RedirectResult(Url.Action("Receive", "Payment")); 
                

            }
            
        }

	}
}