//using HelperBees.Model.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelperBees.Model.Model_HelperBees;

namespace HelperBees
{
    public class BaseController : Controller
    {
        protected HelperBeesContext _context;

        public BaseController() {
            _context = new HelperBeesContext();
            _context.ChangeTracker.LazyLoadingEnabled = true;

            //_context.Configuration.LazyLoadingEnabled = true;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();

            base.Dispose(disposing);
        }
    }
}
