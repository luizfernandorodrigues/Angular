using Microsoft.EntityFrameworkCore.Migrations;

namespace Modelo.Infra.Data.Migrations
{
    public partial class VersaoBanco_0004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                schema: "Acesso",
                table: "Usuario",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SobreNome",
                schema: "Acesso",
                table: "Usuario",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                schema: "Acesso",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "SobreNome",
                schema: "Acesso",
                table: "Usuario");
        }
    }
}
