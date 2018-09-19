namespace DataLayer.EnityConfig
{
	using DataLayer.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class TipoResponsavelMapper : IEntityTypeConfiguration<TipoResponsavel>
	{
		public void Configure(EntityTypeBuilder<TipoResponsavel> builder)
		{
			builder
				.Property(s => s.Descricao)
				.HasColumnType("varchar(25)");
		}
	}
}