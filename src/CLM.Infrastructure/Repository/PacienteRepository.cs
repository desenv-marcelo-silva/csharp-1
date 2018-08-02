namespace CLM.Infrastructure.Repository
{
	using CLM.ApplicationCore.Entity;
	using CLM.Infrastructure.Data;

	public class PacienteRepository : EFRepository<Paciente>
	{
		public PacienteRepository(CLMContext contexto) : base(contexto)
		{
		}
	}
}
