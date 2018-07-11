using CLM.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLM.Infrastructure.Data
{
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
					email = "jhon.doe@email.com.br",
					Telefone = "12 98822-3344"
				},
				new Paciente {
					Nome = "Mary Doe",
					email = "mary.doe@email.com.br",
					Telefone = "12 92288-4433"
				}
			};

			context.AddRange(pacientes);
			context.SaveChanges();
		}
    }
}
