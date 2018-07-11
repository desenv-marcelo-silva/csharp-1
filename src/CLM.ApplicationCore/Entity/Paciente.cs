using System;
using System.Collections.Generic;
using System.Text;

namespace CLM.ApplicationCore.Entity
{
    public class Paciente
    {
		public Paciente()
		{

		}

		public int PacienteId { get; set; }
		public string Nome { get; set; }
		public string email { get; set; }
		public string Telefone { get; set; }

	}
}
