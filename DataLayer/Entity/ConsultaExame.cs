using System;

namespace DataLayer.Entity
{
	public class ConsultaExame
	{
		public int ConsultaExameId { get; set; }
		public Exame Exame { get; set; }
		public Consulta Consulta { get; set; }
		public DateTime DataEntrega { get; set; }
		public bool Entregue { get; set; }
	}
}
