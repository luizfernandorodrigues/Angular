using Microsoft.EntityFrameworkCore.Migrations;

namespace Modelo.Infra.Data.Migrations
{
    public partial class VersaoBanco_0003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                schema: "Cadastro",
                table: "Pais",
                type: "VARCHAR(10)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldNullable: true,
                oldDefaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                schema: "Cadastro",
                table: "Pais",
                type: "VARCHAR(10)",
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldDefaultValue: "");
        }
    }
}
