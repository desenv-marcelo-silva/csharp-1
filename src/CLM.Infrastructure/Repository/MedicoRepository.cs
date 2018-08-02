using CLM.ApplicationCore.Entity;
using CLM.Infrastructure.Data;

namespace CLM.Infrastructure.Repository
{
	public class MedicoRepository : EFRepository<Medico>
	{
		public MedicoRepository(CLMContext contexto) : base(contexto)
		{
		}
	}
}
