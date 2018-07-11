using CLM.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLM.Infrastructure.Data
{
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

			modelBuilder.Entity<Medico>()
				.Property(e => e.CRM)
				.HasColumnType("varchar(15)");

			modelBuilder.Entity<Paciente>()
				.Property(e => e.Nome)
				.HasColumnType("varchar(50)");

			modelBuilder.Entity<Paciente>()
				.Property(e => e.email)
				.HasColumnType("varchar(50)");

			#endregion
			//base.OnModelCreating(modelBuilder);
		}
	}
}
