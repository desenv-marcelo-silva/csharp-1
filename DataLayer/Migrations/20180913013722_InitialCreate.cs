using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    EspecialidadeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_Especialidade", x => x.EspecialidadeId));

            migrationBuilder.CreateTable(
                name: "Exame",
                columns: table => new
                {
                    ExameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_Exame", x => x.ExameId));

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    MedicamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeGenerico = table.Column<string>(nullable: true),
                    NomeComercial = table.Column<string>(nullable: true),
                    Fornecedor = table.Column<string>(nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_Medicamento", x => x.MedicamentoId));

            migrationBuilder.CreateTable(
                name: "SituacaoRegistro",
                columns: table => new
                {
                    SituacaoRegistroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_SituacaoRegistro", x => x.SituacaoRegistroId));

            migrationBuilder.CreateTable(
                name: "TipoColaborador",
                columns: table => new
                {
                    TipoColaboradorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TipoColaborador", x => x.TipoColaboradorId));

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TipoDocumento", x => x.TipoDocumentoId));

            migrationBuilder.CreateTable(
                name: "TipoResponsavel",
                columns: table => new
                {
                    TipoResponsavelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TipoResponsavel", x => x.TipoResponsavelId));

            migrationBuilder.CreateTable(
                name: "TipoTelefone",
                columns: table => new
                {
                    TipoTelefoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_TipoTelefone", x => x.TipoTelefoneId));

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true),
                    CRM = table.Column<string>(type: "varchar(15)", nullable: true),
                    SituacaoRegistroId = table.Column<int>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataInativacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedicoId);
                    table.ForeignKey(
                        name: "FK_Medico_SituacaoRegistro_SituacaoRegistroId",
                        column: x => x.SituacaoRegistroId,
                        principalTable: "SituacaoRegistro",
                        principalColumn: "SituacaoRegistroId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    ColaboradorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    TipoColaboradorId = table.Column<int>(nullable: true),
                    SituacaoRegistroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.ColaboradorId);
                    table.ForeignKey(
                        name: "FK_Colaborador_SituacaoRegistro_SituacaoRegistroId",
                        column: x => x.SituacaoRegistroId,
                        principalTable: "SituacaoRegistro",
                        principalColumn: "SituacaoRegistroId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Colaborador_TipoColaborador_TipoColaboradorId",
                        column: x => x.TipoColaboradorId,
                        principalTable: "TipoColaborador",
                        principalColumn: "TipoColaboradorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PacienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true),
                    Responsavel = table.Column<string>(type: "varchar(100)", nullable: true),
                    TituloResponsavelTipoResponsavelId = table.Column<int>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Documento = table.Column<string>(type: "varchar(20)", nullable: true),
                    TipoDocumentoId = table.Column<int>(nullable: true),
                    Telefone1 = table.Column<string>(type: "varchar(10)", nullable: true),
                    TipoTelefone1TipoTelefoneId = table.Column<int>(nullable: true),
                    Telefone2 = table.Column<string>(type: "varchar(10)", nullable: true),
                    TipoTelefone2TipoTelefoneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteId);
                    table.ForeignKey(
                        name: "FK_Paciente_TipoDocumento_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumento",
                        principalColumn: "TipoDocumentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paciente_TipoTelefone_TipoTelefone1TipoTelefoneId",
                        column: x => x.TipoTelefone1TipoTelefoneId,
                        principalTable: "TipoTelefone",
                        principalColumn: "TipoTelefoneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paciente_TipoTelefone_TipoTelefone2TipoTelefoneId",
                        column: x => x.TipoTelefone2TipoTelefoneId,
                        principalTable: "TipoTelefone",
                        principalColumn: "TipoTelefoneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paciente_TipoResponsavel_TituloResponsavelTipoResponsavelId",
                        column: x => x.TituloResponsavelTipoResponsavelId,
                        principalTable: "TipoResponsavel",
                        principalColumn: "TipoResponsavelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedicoId = table.Column<int>(nullable: true),
                    PacienteId = table.Column<int>(nullable: true),
                    RelatoPaciente = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consulta_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsultaExame",
                columns: table => new
                {
                    ConsultaExameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExameId = table.Column<int>(nullable: true),
                    ConsultaId = table.Column<int>(nullable: true),
                    DataEntrega = table.Column<DateTime>(nullable: false),
                    Entregue = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaExame", x => x.ConsultaExameId);
                    table.ForeignKey(
                        name: "FK_ConsultaExame_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsultaExame_Exame_ExameId",
                        column: x => x.ExameId,
                        principalTable: "Exame",
                        principalColumn: "ExameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsultaMedicamento",
                columns: table => new
                {
                    ConsultaMedicamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedicamentoId = table.Column<int>(nullable: true),
                    ConsultaId = table.Column<int>(nullable: true),
                    Posologia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaMedicamento", x => x.ConsultaMedicamentoId);
                    table.ForeignKey(
                        name: "FK_ConsultaMedicamento_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsultaMedicamento_Medicamento_MedicamentoId",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamento",
                        principalColumn: "MedicamentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_SituacaoRegistroId",
                table: "Colaborador",
                column: "SituacaoRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_TipoColaboradorId",
                table: "Colaborador",
                column: "TipoColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_MedicoId",
                table: "Consulta",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaExame_ConsultaId",
                table: "ConsultaExame",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaExame_ExameId",
                table: "ConsultaExame",
                column: "ExameId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaMedicamento_ConsultaId",
                table: "ConsultaMedicamento",
                column: "ConsultaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaMedicamento_MedicamentoId",
                table: "ConsultaMedicamento",
                column: "MedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_SituacaoRegistroId",
                table: "Medico",
                column: "SituacaoRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TipoDocumentoId",
                table: "Paciente",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TipoTelefone1TipoTelefoneId",
                table: "Paciente",
                column: "TipoTelefone1TipoTelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TipoTelefone2TipoTelefoneId",
                table: "Paciente",
                column: "TipoTelefone2TipoTelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TituloResponsavelTipoResponsavelId",
                table: "Paciente",
                column: "TituloResponsavelTipoResponsavelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "ConsultaExame");

            migrationBuilder.DropTable(
                name: "ConsultaMedicamento");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "TipoColaborador");

            migrationBuilder.DropTable(
                name: "Exame");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "SituacaoRegistro");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "TipoTelefone");

            migrationBuilder.DropTable(
                name: "TipoResponsavel");
        }
    }
}
