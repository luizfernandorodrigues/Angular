using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modelo.Infra.Data.Migrations
{
    public partial class VersaoBanco_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimesTamp = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "GETDATE()"),
                    Empresa_Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Usuario_Ukey = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar", maxLength: 10, nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Ukey);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimesTamp = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Empresa_Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Usuario_Ukey = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar", maxLength: 2, nullable: false),
                    Pais_Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Ukey);
                    table.ForeignKey(
                        name: "FK_Estado_Pais_Pais_Ukey",
                        column: x => x.Pais_Ukey,
                        principalTable: "Pais",
                        principalColumn: "Ukey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimesTamp = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Empresa_Ukey = table.Column<Guid>(nullable: true),
                    Usuario_Ukey = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    CodigoIbge = table.Column<string>(type: "nvarchar", maxLength: 7, nullable: false, defaultValue: "0"),
                    Estado_Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Ukey);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_Estado_Ukey",
                        column: x => x.Estado_Ukey,
                        principalTable: "Estado",
                        principalColumn: "Ukey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cep",
                columns: table => new
                {
                    Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimesTamp = table.Column<DateTime>(nullable: false),
                    Empresa_Ukey = table.Column<Guid>(nullable: true),
                    Usuario_Ukey = table.Column<Guid>(nullable: true),
                    CodigoEnderecamentoPostal = table.Column<string>(type: "nvarchar", maxLength: 8, nullable: false, defaultValue: ""),
                    Cidade_Ukey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cep", x => x.Ukey);
                    table.ForeignKey(
                        name: "FK_Cep_Cidade_Cidade_Ukey",
                        column: x => x.Cidade_Ukey,
                        principalTable: "Cidade",
                        principalColumn: "Ukey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cep_Cidade_Ukey",
                table: "Cep",
                column: "Cidade_Ukey");

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_Estado_Ukey",
                table: "Cidade",
                column: "Estado_Ukey");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_Pais_Ukey",
                table: "Estado",
                column: "Pais_Ukey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cep");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
