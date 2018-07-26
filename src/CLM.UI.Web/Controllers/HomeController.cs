using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CLM.UI.Web.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return RedirectToAction("Index");
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return RedirectToAction("Index");
		}
	}
}
