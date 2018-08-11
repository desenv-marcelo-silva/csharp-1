namespace CLMData.EnityConfig
{
	using CLMData.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class PacienteMapper : IEntityTypeConfiguration<Paciente>
	{
		public void Configure(EntityTypeBuilder<Paciente> builder)
		{
			builder
				.Property(e => e.Nome)
				.HasColumnType("varchar(50)");

			builder
				.Property(e => e.Email)
				.HasColumnType("varchar(50)");
		}
	}
}
