using System;

namespace DataLayer.Entity
{
	public class Consulta
	{
		public int ConsultaId { get; set; }
		public Medico Medico { get; set; }
		public Paciente Paciente { get; set; }
		public string RelatoPaciente { get; set; }
		public DateTime Data { get; set; }
		public string Hora { get; set; }
	}
}
