using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGInvitation.Controllers
{
    public class InviteController : Controller
    {
        // GET: AcceptInvite
        public string Accept()
        {
            return "You are registered for Consumer Group Dogfood";
        }
    }
}