using System;

namespace DataLayer.Entity
{
	public class Medicamento
	{
		public int MedicamentoId { get; set; }
		public string NomeGenerico { get; set; }
		public string NomeComercial { get; set; }
		public string Fornecedor { get; set; }
	}
}
