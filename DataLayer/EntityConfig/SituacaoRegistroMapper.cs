namespace DataLayer.EnityConfig
{
	using DataLayer.Entity;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class SituacaoRegistroMapper : IEntityTypeConfiguration<SituacaoRegistro>
	{
		public void Configure(EntityTypeBuilder<SituacaoRegistro> builder)
		{
			builder
				.Property(s => s.Descricao)
				.HasColumnType("varchar(25)");
		}
	}
}
