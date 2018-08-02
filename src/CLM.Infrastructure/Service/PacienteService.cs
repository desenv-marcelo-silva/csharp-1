namespace CLM.Infrastructure.Service
{
	using CLM.ApplicationCore.Entity;
	using CLM.Infrastructure.Repository;

	public class PacienteService : EFService<Paciente>
	{

		public PacienteService(EFRepository<Paciente> repository) : base(repository)
		{
		}
	}
}
