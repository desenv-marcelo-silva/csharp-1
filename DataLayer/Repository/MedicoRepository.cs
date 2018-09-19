namespace DataLayer.Repository
{
	using DataLayer.Entity;
	using DataLayer.Interface.Repository;
	using DataLayer.Data;

	public class MedicoRepository : EFRepository<Medico>, IMedicoRepository
	{
		public MedicoRepository(DBContexto contexto)
			: base(contexto)
		{
		}
	}
}
