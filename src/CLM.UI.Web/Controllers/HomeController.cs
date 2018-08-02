using CLM.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace CLM.UI.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly MedicoService _medicoService;

		public HomeController()
		{
			MedicoService medicoService = new MedicoService()
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
