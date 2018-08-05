namespace CLM.Infrastructure.Repository
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;
	using CLM.ApplicationCore.Entity;
	using CLM.ApplicationCore.Interface.Repository;
	using CLM.Infrastructure.Data;
	using Microsoft.EntityFrameworkCore;

	public class PacienteRepository : IPacienteRepository
	{
		private readonly CLMContext _dbContext;

		public PacienteRepository(CLMContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Paciente Adicionar(Paciente entidade)
		{
			_dbContext.Set<Paciente>().Add(entidade);
			_dbContext.SaveChanges();
			return entidade;
		}

		public void Atualizar(Paciente entidade)
		{
			_dbContext.Entry(entidade).State = EntityState.Modified;
			_dbContext.SaveChanges();
		}

		public IEnumerable<Paciente> Buscar(Expression<Func<Paciente, bool>> predicado)
		{
			return _dbContext.Set<Paciente>().Where(predicado).AsEnumerable();
		}

		public Paciente ObterPorId(int Id)
		{
			return _dbContext.Set<Paciente>().Find(Id);
		}

		public IEnumerable<Paciente> ObterTodos()
		{
			return _dbContext.Set<Paciente>().AsEnumerable();
		}

		public void Remover(Paciente entidade)
		{
			_dbContext.Set<Paciente>().Remove(entidade);
		}
	}
}