using System;

namespace DataLayer.Entity
{
	public class Paciente
	{
		public int PacienteId { get; set; }
		public string Nome { get; set; }
		public string Responsavel { get; set; }
		public TipoResponsavel TituloResponsavel { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Documento { get; set; }
		public TipoDocumento TipoDocumento { get; set; }
		public string Telefone1 { get; set; }
		public TipoTelefone TipoTelefone1 { get; set; }
		public string Telefone2 { get; set; }
		public TipoTelefone TipoTelefone2 { get; set; }
	}
}
