using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CLM.ApplicationCore.Entity;
using CLM.ApplicationCore.Interface.Repository;
using CLM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CLM.Infrastructure.Repository
{

	public class MedicoRepository : IMedicoRepository
	{
		private readonly CLMContext _dbContext;

		public MedicoRepository(CLMContext contexto)
		{
			_dbContext = contexto;
		}

		public Medico Adicionar(Medico entidade)
		{
			_dbContext.Set<Medico>().Add(entidade);
			_dbContext.SaveChanges();
			return entidade;
		}

		public void Atualizar(Medico entidade)
		{
			_dbContext.Entry(entidade).State = EntityState.Modified;
			_dbContext.SaveChanges();
		}

		public IEnumerable<Medico> Buscar(Expression<Func<Medico, bool>> predicado)
		{
			return _dbContext.Set<Medico>().Where(predicado).AsEnumerable();
		}

		public Medico ObterPorId(int Id)
		{
			return _dbContext.Set<Medico>().Find(Id);
		}

		public IEnumerable<Medico> ObterTodos()
		{
			return _dbContext.Set<Medico>().AsEnumerable();
		}

		public void Remover(Medico entidade)
		{
			_dbContext.Set<Medico>().Remove(entidade);
			_dbContext.SaveChanges();
		}
	}
}
