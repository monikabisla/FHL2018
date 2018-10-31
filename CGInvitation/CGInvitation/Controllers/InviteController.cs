using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CGInvitation.Controllers
{
    public class InviteController : Controller
    {
        private static string InviteCompleted = @"You can now start to use consumer groups to coordinate and collaborate with others. You will find consumer groups in the left navigation of your Outlook web experience where you can see groups you are memebers of and even create a groups.";

        // GET: AcceptInvite
        public ActionResult Accept()
        {
            ViewBag.InviteCompletedText = InviteController.InviteCompleted;
            return View();
        }
    }
}