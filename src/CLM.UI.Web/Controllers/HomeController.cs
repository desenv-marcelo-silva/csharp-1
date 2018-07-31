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

		public string TesteMeu()
		{
			return "Estou na testemeu";
		}
	}
}
