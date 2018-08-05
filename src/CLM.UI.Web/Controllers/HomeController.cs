using CLM.ApplicationCore.Interface.Services;
using CLM.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace CLM.UI.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly IMedicoService _medicoService;

		public HomeController(IMedicoService medicoService)
		{
			_medicoService = medicoService;
		}

		public IActionResult Index()
		{
			return View(_medicoService.ObterTodos());
		}

		public string TesteMeu()
		{
			return "Estou na testemeu";
		}
	}
}
