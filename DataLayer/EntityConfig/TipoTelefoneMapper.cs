namespace DataLayer.EnityConfig
{
	using DataLayer.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class TipoTelefoneMapper : IEntityTypeConfiguration<TipoTelefone>
	{
		public void Configure(EntityTypeBuilder<TipoTelefone> builder)
		{
			builder
				.Property(s => s.Descricao)
				.HasColumnType("varchar(25)");
		}
	}
}