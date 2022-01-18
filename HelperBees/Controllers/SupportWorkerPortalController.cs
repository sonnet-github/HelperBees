using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperBees.Controllers
{
    public class SupportWorkerPortalController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Inbox()
        {
            return View();
        }

        public ActionResult InboxDialogue()
        {
            return View();
        }

        public ActionResult TimeSheets()
        {
            return View();
        }

        public ActionResult MyClients()
        {
            return View();
        }
    }
}
