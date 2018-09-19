using System;

namespace DataLayer.Entity
{
	public class Colaborador
	{
		public int ColaboradorId { get; set; }
		public string Descricao { get; set; }
		public string Nome { get; set; }
		public string Login { get; set; }
		public string Senha { get; set; }
		public TipoColaborador Tipo { get; set; }
		public SituacaoRegistro Situacao { get; set; }
	}
}
