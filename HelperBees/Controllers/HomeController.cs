using HelperBees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelperBess;
using HelperBess.WebApiCore.Models;
using HelperBess.WebApiCore.IServices;

namespace HelperBees.Controllers
{
    public class HomeController : Controller
    {
		private static readonly IList<CommentModel> _comments;

		static HomeController()
		{
			HelperBeesContext db = new HelperBeesContext();
			ISwSupportWorkerService swservice = new HelperBess.WebApiCore.Services.SwSupportWorkerService(db);
			var test = swservice.GetSwSupportWorkerById(1);

			_comments = new List<CommentModel>
			{
				new CommentModel
				{
					Id = test.SupportWorkerId,
					Author = test.EmailAddress,
					Text = test.DateCreated.ToString()
				},
				new CommentModel
				{
					Id = 2,
					Author = "Pete Hunt",
					Text = "This is one comment"
				},
				new CommentModel
				{
					Id = 3,
					Author = "Jordan Walke",
					Text = "This is *another* comment"
				},
			};
		}

		public ActionResult Index()
		{
			return View(_comments);
		}

		[Route("comments")]
		[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
		public ActionResult Comments()
		{
			return Json(_comments);
		}

		[Route("comments/new")]
		[HttpPost]
		public ActionResult AddComment(CommentModel comment)
		{
            // Create a fake ID for this comment

            HelperBeesContext db = new HelperBeesContext();
            ISwSupportWorkerService swservice = new HelperBess.WebApiCore.Services.SwSupportWorkerService(db);

            var swsworker = new SwSupportWorker()
            {
                EmailAddress = comment.Author,
                DateCreated = Convert.ToDateTime(comment.Text)

            };

            swservice.AddSwSupportWorker(swsworker);

            comment.Id = _comments.Count + 1;
			_comments.Add(comment);
			return Content("Success :)");
		}
	}
}
