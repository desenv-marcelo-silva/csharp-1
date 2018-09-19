using System;

namespace DataLayer.Entity
{
	public class ConsultaMedicamento
	{
		public int ConsultaMedicamentoId { get; set; }
		public Medicamento Medicamento { get; set; }
		public Consulta Consulta { get; set; }
		public string Posologia { get; set; }
	}
}
