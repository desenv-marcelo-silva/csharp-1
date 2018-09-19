namespace DataLayer.EnityConfig
{
	using DataLayer.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class TipoDocumentoMapper : IEntityTypeConfiguration<TipoDocumento>
	{
		public void Configure(EntityTypeBuilder<TipoDocumento> builder)
		{
			builder
				.Property(s => s.Descricao)
				.HasColumnType("varchar(25)");
		}
	}
}