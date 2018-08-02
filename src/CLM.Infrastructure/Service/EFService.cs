using CLM.ApplicationCore.Interface.Services;
using CLM.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CLM.Infrastructure.Service
{
	public class EFService<T> : IService<T> where T : class
	{
		private readonly EFRepository<T> _repository;

		public EFService(EFRepository<T> repository)
		{
			_repository = repository;
		}

		public T Adicionar(T entidade)
		{
			return _repository.Adicionar(entidade);
		}

		public void Atualizar(T entidade)
		{
			_repository.Atualizar(entidade);
		}

		public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
		{
			return _repository.Buscar(predicado);
		}

		public T ObterPorId(int Id)
		{
			return _repository.ObterPorId(Id);
		}

		public IEnumerable<T> ObterTodos()
		{
			return _repository.ObterTodos();
		}

		public void Remover(T entidade)
		{
			_repository.Remover(entidade);
		}
	}
}
