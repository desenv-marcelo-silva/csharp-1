using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _1._ApresentacaoLayer.Models;

namespace _1._ApresentacaoLayer.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Tabelas()
		{
			ViewData["Message"] = "Tabelas";

			return View();
		}
		public IActionResult Consultas()
		{
			ViewData["Message"] = "Consultas";

			return View();
		}

		public IActionResult Exames()
		{
			ViewData["Message"] = "Exames";

			return View();
		}
		public IActionResult Finalizar()
		{
			ViewData["Message"] = "Finalizar";

			return View();
		}

		public IActionResult Privacidade()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
