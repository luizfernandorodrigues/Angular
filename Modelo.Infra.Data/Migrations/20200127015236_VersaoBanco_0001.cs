using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modelo.Infra.Data.Migrations
{
    public partial class VersaoBanco_0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Cadastro");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimesTamp = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()"),
                    Email = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                schema: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimesTamp = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()"),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Codigo = table.Column<string>(type: "VARCHAR(10)", nullable: true, defaultValue: ""),
                    Observacoes = table.Column<string>(type: "VARCHAR(MAX)", nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                schema: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimesTamp = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Sigla = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    Pais_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Estado_Pais",
                        column: x => x.Pais_Id,
                        principalSchema: "Cadastro",
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                schema: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimesTamp = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()"),
                    Nome = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CodigoIbge = table.Column<string>(type: "VARCHAR(7)", nullable: false),
                    Estado_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Cidade_Estado",
                        column: x => x.Estado_Id,
                        principalSchema: "Cadastro",
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cep",
                schema: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimesTamp = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()"),
                    CodigoEnderecamentoPostal = table.Column<string>(type: "VARCHAR(8)", nullable: false),
                    Cidade_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cep", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Cep_Cidade",
                        column: x => x.Cidade_Id,
                        principalSchema: "Cadastro",
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cep_Cidade_Id",
                schema: "Cadastro",
                table: "Cep",
                column: "Cidade_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_Estado_Id",
                schema: "Cadastro",
                table: "Cidade",
                column: "Estado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_Pais_Id",
                schema: "Cadastro",
                table: "Estado",
                column: "Pais_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cep",
                schema: "Cadastro");

            migrationBuilder.DropTable(
                name: "Cidade",
                schema: "Cadastro");

            migrationBuilder.DropTable(
                name: "Estado",
                schema: "Cadastro");

            migrationBuilder.DropTable(
                name: "Pais",
                schema: "Cadastro");
        }
    }
}
