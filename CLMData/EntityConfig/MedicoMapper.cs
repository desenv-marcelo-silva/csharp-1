namespace CLMData.EnityConfig
{
	using CLMData.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	internal class MedicoMapper : IEntityTypeConfiguration<Medico>
	{
		public void Configure(EntityTypeBuilder<Medico> builder)
		{
			builder
				.Property(e => e.CRM)
				.HasColumnType("varchar(15)");
		}
	}
}