namespace CLMData.Repository
{
	using CLMData.Entity;
	using CLMData.Interface.Repository;
	using CLMData.Data;

	public class PacienteRepository : EFRepository<Paciente>, IPacienteRepository
	{
		public PacienteRepository(CLMContext contexto) 
			: base(contexto)
		{
		}
	}
}