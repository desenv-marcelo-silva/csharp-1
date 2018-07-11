using System;
using System.Collections.Generic;
using System.Text;

namespace CLM.ApplicationCore.Entity
{
    public class Medico
    {
		public Medico()
		{

		}

		public int MedicoId { get; set; }
		public string Nome { get; set; }
		public string CRM { get; set; }
	}
}
