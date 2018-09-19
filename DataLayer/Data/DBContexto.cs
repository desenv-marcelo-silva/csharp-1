namespace DataLayer.Data
{
	using DataLayer.EnityConfig;
	using DataLayer.Entity;
	using Microsoft.EntityFrameworkCore;

	public class DBContexto : DbContext
	{
		public DBContexto(DbContextOptions<DBContexto> options)
			: base(options)
		{

		}

		#region Tabelas/DBSets

		public DbSet<SituacaoRegistro> SituacaoRegistro { get; set; }
		public DbSet<TipoDocumento> TipoDocumento { get; set; }
		public DbSet<TipoResponsavel> TipoResponsavel { get; set; }
		public DbSet<TipoTelefone> TipoTelefone { get; set; }
		public DbSet<TipoColaborador> TipoColaborador { get; set; }
		public DbSet<Especialidade> Especialidade { get; set; }
		public DbSet<Medicamento> Medicamento { get; set; }
		public DbSet<Medico> Medico { get; set; }
		public DbSet<Paciente> Paciente { get; set; }

		public DbSet<Consulta> Consulta { get; set; }
		public DbSet<Exame> Exame { get; set; }
		public DbSet<ConsultaExame> ConsultaExame { get; set; }
		public DbSet<ConsultaMedicamento> ConsultaMedicamento { get; set; }
		public DbSet<Colaborador> Colaborador { get; set; }

		#endregion

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Tabelas físicas

			modelBuilder.Entity<SituacaoRegistro>().ToTable("SituacaoRegistro");
			modelBuilder.Entity<TipoDocumento>().ToTable("TipoDocumento");
			modelBuilder.Entity<TipoResponsavel>().ToTable("TipoResponsavel");
			modelBuilder.Entity<TipoTelefone>().ToTable("TipoTelefone");
			modelBuilder.Entity<TipoColaborador>().ToTable("TipoColaborador");
			modelBuilder.Entity<Especialidade>().ToTable("Especialidade");
			modelBuilder.Entity<Medicamento>().ToTable("Medicamento");
			modelBuilder.Entity<Medico>().ToTable("Medico");
			modelBuilder.Entity<Paciente>().ToTable("Paciente");
			modelBuilder.Entity<Consulta>().ToTable("Consulta");
			modelBuilder.Entity<Exame>().ToTable("Exame");
			modelBuilder.Entity<ConsultaExame>().ToTable("ConsultaExame");
			modelBuilder.Entity<ConsultaMedicamento>().ToTable("ConsultaMedicamento");
			modelBuilder.Entity<Colaborador>().ToTable("Colaborador");

			#endregion

			#region Alteração de campos

			modelBuilder.ApplyConfiguration(new SituacaoRegistroMapper());

			modelBuilder.ApplyConfiguration(new TipoDocumentoMapper());

			modelBuilder.ApplyConfiguration(new TipoResponsavelMapper());

			modelBuilder.ApplyConfiguration(new MedicoMapper());

			modelBuilder.ApplyConfiguration(new PacienteMapper());

			#endregion
			base.OnModelCreating(modelBuilder);
		}
	}
}
