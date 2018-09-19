namespace DataLayer.EnityConfig
{
	using DataLayer.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	internal class MedicoMapper : IEntityTypeConfiguration<Medico>
	{
		public void Configure(EntityTypeBuilder<Medico> builder)
		{
			builder
				.Property(m => m.CRM)
				.HasColumnType("varchar(15)");

			builder
				.Property(m => m.Nome)
				.HasColumnType("varchar(100)");
		}
	}
}