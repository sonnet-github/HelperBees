using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperBees.Controllers
{
    public class MemberPortalController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult AccountDetails()
        {
            return View();
        }

        public ActionResult CareRecipientDetails()
        {
            return View();
        }

        public ActionResult MedicalDetails()
        {
            return View();
        }

        public ActionResult PaymentDetails()
        {
            return View();
        }

        public ActionResult SupportingInfo()
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

        public ActionResult JobPosts()
        {
            return View();
        }

        public ActionResult JobSubmission()
        {
            return View();
        }

        public ActionResult TimeSheets()
        {
            return View();
        }

        public ActionResult MyAccount()
        {
            return View();
        }

        public ActionResult SupportWorkers()
        {
            return View();
        }
    }
}
