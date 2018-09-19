namespace CLMService.Interface
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public interface IService<TEntity> where TEntity : class
	{
		TEntity Adicionar(TEntity entidade);
		TEntity ObterPorId(int Id);
		IEnumerable<TEntity> ObterTodos();
		IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado);
		void Atualizar(TEntity entidade);
		void Remover(TEntity entidade);
	}
}
