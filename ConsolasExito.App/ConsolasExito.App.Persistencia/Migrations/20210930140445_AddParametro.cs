using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsolasExito.App.Persistencia.Migrations
{
    public partial class AddParametro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoProducto",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoProducto",
                table: "Productos");
        }
    }
}
