﻿namespace CLMData.Data
{
	using CLMData.Entity;
	using System.Linq;

	public static class DbInitializer
	{
		public static void Initialize(CLMContext context)
		{
			if (context.Pacientes.Any())
			{
				return;
			}

			var pacientes = new Paciente[]
			{
				new Paciente {
					Nome = "Jhon Doe",
					Email = "jhon.doe@email.com.br",
					Telefone = "12 98822-3344"
				},
				new Paciente {
					Nome = "Mary Doe",
					Email = "mary.doe@email.com.br",
					Telefone = "12 92288-4433"
				}
			};

			context.AddRange(pacientes);
			context.SaveChanges();
		}
	}
}