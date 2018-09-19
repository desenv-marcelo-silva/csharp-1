using System;

namespace DataLayer.Entity
{
	public class Medico
	{
		public int MedicoId { get; set; }
		public string Nome { get; set; }
		public string CRM { get; set; }
		public SituacaoRegistro Situacao { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime DataInativacao { get; set; }
	}
}
