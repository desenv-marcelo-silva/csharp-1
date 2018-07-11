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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configura o entity
			modelBuilder.Entity<Medico>().ToTable("Medico");
			//base.OnModelCreating(modelBuilder);
		}
	}
}
