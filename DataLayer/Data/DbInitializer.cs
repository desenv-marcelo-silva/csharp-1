namespace DataLayer.Data
{
	using DataLayer.Entity;
	using System;
	using System.Linq;

	public static class DbInitializer
	{
		public static void Initialize(DBContexto context)
		{
			InicializarTabelaSituacaoRegistro(context);
			InicializarTabelaTipoDocumento(context);
			InicializarTabelaTipoResponsavel(context);
			InicializarTabelaTipoTelefone(context);
			InicializarTabelaTipoColaborador(context);
			InicializarTabelaPaciente(context);
		}

		private static void InicializarTabelaTipoColaborador(DBContexto context)
		{
			if (context.TipoColaborador.Any())
			{
				return;
			}
			var tipoColaborador = new TipoColaborador[]
			{
				new TipoColaborador {
					Descricao = "Médico"
				},
				new TipoColaborador {
					Descricao = "Funcionário"
				},
				new TipoColaborador {
					Descricao = "Administrador"
				}
			};

			context.AddRange(tipoColaborador);
			context.SaveChanges();
		}

		private static void InicializarTabelaTipoTelefone(DBContexto context)
		{
			if (context.TipoTelefone.Any())
			{
				return;
			}

			var tipoTelefone = new TipoTelefone[]
			{
				new TipoTelefone {
					Descricao = "Celular"
				},
				new TipoTelefone {
					Descricao = "Residencial"
				},
				new TipoTelefone {
					Descricao = "Recado"
				},
				new TipoTelefone {
					Descricao = "Trabalho"
				},
				new TipoTelefone {
					Descricao = "Outros"
				}
			};

			context.AddRange(tipoTelefone);
			context.SaveChanges();
		}

		private static void InicializarTabelaTipoDocumento(DBContexto context)
		{
			if (context.TipoDocumento.Any())
			{
				return;
			}

			var tipoDocumento = new TipoDocumento[]
			{
				new TipoDocumento {
					Descricao = "RG"
				},
				new TipoDocumento {
					Descricao = "CPF"
				},
				new TipoDocumento {
					Descricao = "CNH"
				},
				new TipoDocumento {
					Descricao = "Passaporte"
				}
			};

			context.AddRange(tipoDocumento);
			context.SaveChanges();
		}

		private static void InicializarTabelaTipoResponsavel(DBContexto context)
		{
			if (context.TipoResponsavel.Any())
			{
				return;
			}

			var tipoResponsavel = new TipoResponsavel[]
			{
				new TipoResponsavel {
					Descricao = "Mãe"
				},
				new TipoResponsavel {
					Descricao = "Pai"
				},
				new TipoResponsavel {
					Descricao = "Avô"
				},
				new TipoResponsavel {
					Descricao = "Avó"
				},
				new TipoResponsavel {
					Descricao = "Tia"
				},
				new TipoResponsavel {
					Descricao = "Tio"
				},
				new TipoResponsavel {
					Descricao = "Outro"
				}
			};

			context.AddRange(tipoResponsavel);
			context.SaveChanges();
		}

		private static void InicializarTabelaSituacaoRegistro(DBContexto context)
		{
			if (context.SituacaoRegistro.Any())
			{
				return;
			}

			var situacaoRegistro = new SituacaoRegistro[]
			{
				new SituacaoRegistro {
					Descricao = "Ativo"
				},
				new SituacaoRegistro {
					Descricao = "Inativo"
				}
			};

			context.AddRange(situacaoRegistro);
			context.SaveChanges();
		}

		private static void InicializarTabelaPaciente(DBContexto context)
		{
			if (context.Paciente.Any())
			{
				return;
			}

			var pacientes = new Paciente[]
			{
				new Paciente {
					Nome = "Jhon Doe",
					Telefone1 = "12 98822-3344"
				},
				new Paciente {
					Nome = "Mary Doe",
					Telefone1 = "12 92288-4433",
					Telefone2 = "12 98933-3399"
				}
			};

			context.AddRange(pacientes);
			context.SaveChanges();
		}
	}
}
