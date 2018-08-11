﻿namespace CLMData.Data
{
	using CLMData.EnityConfig;
	using CLMData.Entity;
	using Microsoft.EntityFrameworkCore;

	public class CLMContext : DbContext
	{
		public CLMContext(DbContextOptions<CLMContext> options) 
			: base(options)
		{
			
		}

		public DbSet<Medico> Medicos { get; set; }
		public DbSet<Paciente> Pacientes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configura o entity
			#region Tabelas

			modelBuilder.Entity<Medico>().ToTable("Medico");
			modelBuilder.Entity<Paciente>().ToTable("Paciente");

			#endregion

			#region Alteração de campos

			modelBuilder.ApplyConfiguration(new MedicoMapper());

			modelBuilder.ApplyConfiguration(new PacienteMapper());

			#endregion
			//base.OnModelCreating(modelBuilder);
		}
	}
}