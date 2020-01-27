using Microsoft.EntityFrameworkCore.Migrations;

namespace Modelo.Infra.Data.Migrations
{
    public partial class VersaoBanco_0002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Acesso");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuario",
                newSchema: "Acesso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Usuario",
                schema: "Acesso",
                newName: "Usuario");
        }
    }
}
