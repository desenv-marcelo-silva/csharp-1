namespace CLM.Infrastructure.Service
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;
	using CLM.ApplicationCore.Entity;
	using CLM.ApplicationCore.Interface.Repository;
	using CLM.ApplicationCore.Interface.Services;

	public class MedicoService : IMedicoService
	{
		private readonly IMedicoRepository _medicoRepository;

		public MedicoService(IMedicoRepository medicoRepository)
		{
			_medicoRepository = medicoRepository;
		}

		public Medico Adicionar(Medico entidade)
		{
			return _medicoRepository.Adicionar(entidade);
		}

		public void Atualizar(Medico entidade)
		{
			_medicoRepository.Atualizar(entidade);
		}

		public IEnumerable<Medico> Buscar(Expression<Func<Medico, bool>> predicado)
		{
			return _medicoRepository.Buscar(predicado);
		}

		public Medico ObterPorId(int Id)
		{
			return _medicoRepository.ObterPorId(Id);
		}

		public IEnumerable<Medico> ObterTodos()
		{
			return _medicoRepository.ObterTodos();
		}

		public void Remover(Medico entidade)
		{
			_medicoRepository.Remover(entidade);
		}
	}
}