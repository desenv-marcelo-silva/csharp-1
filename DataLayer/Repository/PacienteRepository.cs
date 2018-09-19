namespace DataLayer.Repository
{
	using DataLayer.Entity;
	using DataLayer.Interface.Repository;
	using DataLayer.Data;

	public class PacienteRepository : EFRepository<Paciente>, IPacienteRepository
	{
		public PacienteRepository(DBContexto contexto)
			: base(contexto)
		{
		}
	}
}