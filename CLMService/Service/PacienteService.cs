namespace CLMService.Service
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;
	using CLMData.Entity;
	using CLMData.Interface.Repository;
	using CLMData.Interface.Services;

	public class PacienteService : IPacienteService
	{
		private readonly IPacienteRepository _pacienteRepository;

		public PacienteService(IPacienteRepository pacienteRepository)
		{
			_pacienteRepository = pacienteRepository;
		}

		public Paciente Adicionar(Paciente entidade)
		{
			return _pacienteRepository.Adicionar(entidade);
		}

		public void Atualizar(Paciente entidade)
		{
			_pacienteRepository.Atualizar(entidade);
		}

		public IEnumerable<Paciente> Buscar(Expression<Func<Paciente, bool>> predicado)
		{
			return _pacienteRepository.Buscar(predicado);
		}

		public Paciente ObterPorId(int Id)
		{
			return _pacienteRepository.ObterPorId(Id);
		}

		public IEnumerable<Paciente> ObterTodos()
		{
			return _pacienteRepository.ObterTodos();
		}

		public void Remover(Paciente entidade)
		{
			_pacienteRepository.Remover(entidade);
		}
	}
}