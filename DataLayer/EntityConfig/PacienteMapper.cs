namespace DataLayer.EnityConfig
{
	using DataLayer.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class PacienteMapper : IEntityTypeConfiguration<Paciente>
	{
		public void Configure(EntityTypeBuilder<Paciente> builder)
		{
			builder
				.Property(p => p.Nome)
				.HasColumnType("varchar(100)");

			builder
				.Property(p => p.Responsavel)
				.HasColumnType("varchar(100)");

			builder
				.Property(p => p.Telefone1)
				.HasColumnType("varchar(10)");

			builder
				.Property(p => p.Telefone2)
				.HasColumnType("varchar(10)");

			builder
				.Property(p => p.Documento)
				.HasColumnType("varchar(20)");
		}
	}
}