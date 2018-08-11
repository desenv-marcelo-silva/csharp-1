namespace CLMData.Repository
{
	using CLMData.Entity;
	using CLMData.Interface.Repository;
	using CLMData.Data;

	public class MedicoRepository : EFRepository<Medico>, IMedicoRepository
	{
		public MedicoRepository(CLMContext contexto) 
			: base(contexto)
		{
		}
	}
}
