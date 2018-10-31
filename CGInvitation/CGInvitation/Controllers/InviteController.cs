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
        private static string InviteCompleted = @"You are registered for Consumer Groups Dogfood.";

        // GET: AcceptInvite
        public ActionResult Accept()
        {
            ViewBag.InviteCompletedText = InviteController.InviteCompleted;
            return View();
        }
    }
}