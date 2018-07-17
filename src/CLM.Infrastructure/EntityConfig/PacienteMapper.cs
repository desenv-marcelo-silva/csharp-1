using CLM.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLM.Infrastructure.EntityConfig
{
	public class PacienteMapper : IEntityTypeConfiguration<Paciente>
	{
		public void Configure(EntityTypeBuilder<Paciente> builder)
		{
			builder
				.Property(e => e.Nome)
				.HasColumnType("varchar(50)");

			builder
				.Property(e => e.email)
				.HasColumnType("varchar(50)");
		}
	}
}
