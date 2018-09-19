namespace DataLayer.Repository
{
	using DataLayer.Interface.Repository;
	using DataLayer.Data;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;

	public abstract class EFRepository<T> : IRepository<T> where T : class
	{
		private readonly DBContexto _dbContext;

		protected EFRepository(DBContexto dbContext)
		{
			_dbContext = dbContext;
		}

		public T Adicionar(T entidade)
		{
			_dbContext.Set<T>().Add(entidade);
			_dbContext.SaveChanges();
			return entidade;
		}

		public void Atualizar(T entidade)
		{
			_dbContext.Entry(entidade).State = EntityState.Modified;
			_dbContext.SaveChanges();
		}

		public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
		{
			return _dbContext.Set<T>().Where(predicado).AsEnumerable();
		}

		public T ObterPorId(int Id)
		{
			return _dbContext.Set<T>().Find(Id);
		}

		public IEnumerable<T> ObterTodos()
		{
			return _dbContext.Set<T>().AsEnumerable();
		}

		public void Remover(T entidade)
		{
			_dbContext.Set<T>().Remove(entidade);
			_dbContext.SaveChanges();
		}
	}
}
