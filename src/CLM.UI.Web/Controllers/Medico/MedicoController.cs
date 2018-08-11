using CLM.UI.Web.Models.MedicoViewModels;
using CLMData.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CLM.UI.Web.Controllers.Medico
{
	public class MedicoController : Controller
	{
		private readonly IMedicoService _medicoService;

		public MedicoController(IMedicoService medicoService)
		{
			_medicoService = medicoService;
		}
		public IActionResult Index()
		{
			var medicos = _medicoService.ObterTodos();
			var medicoViewModel = MedicoMapper(medicos);
			return View(medicoViewModel);
		}
		private ListaMedicoViewModel MedicoMapper(IEnumerable<CLMData.Entity.Medico> medicos)
		{
			var medicoModel = medicos.Select(result => new MedicoViewModel
			{
				MedicoId = result.MedicoId,
				Nome = result.Nome,
				CRM = result.CRM
			});

			var vmodel = new ListaMedicoViewModel()
			{
				Medicos = medicoModel
			};
			return vmodel;
		}

	}
}