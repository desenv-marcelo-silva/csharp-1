namespace CLM.Infrastructure.Service
{
	using CLM.ApplicationCore.Entity;
	using CLM.Infrastructure.Repository;

	public class MedicoService : EFService<Medico>
	{

		public MedicoService(EFRepository<Medico> repository) : base(repository)
		{
		}

	}
}