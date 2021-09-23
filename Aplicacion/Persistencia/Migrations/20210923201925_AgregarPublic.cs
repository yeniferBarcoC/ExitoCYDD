using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class AgregarPublic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CapacidadAlmacenamiento",
                table: "productos",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EsMultiPlataforma",
                table: "productos",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fabricante",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaCompra",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaVenta",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdConsolasP",
                table: "productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdControles",
                table: "productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdVideoJuego",
                table: "productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroControles",
                table: "productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PrecioCompra",
                table: "productos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PrecioVenta",
                table: "productos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TipoAlmacenamiento",
                table: "productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoControl",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VelocidadProcesamiento",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VelocidadRam",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoJuego_Fabricante",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoJuego_Nombre",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoJuego_Version",
                table: "productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadosId",
                table: "facturas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contrasenna",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sucursal",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoEmpleado",
                table: "empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_facturas_EmpleadosId",
                table: "facturas",
                column: "EmpleadosId");

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_empleados_EmpleadosId",
                table: "facturas",
                column: "EmpleadosId",
                principalTable: "empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facturas_empleados_EmpleadosId",
                table: "facturas");

            migrationBuilder.DropIndex(
                name: "IX_facturas_EmpleadosId",
                table: "facturas");

            migrationBuilder.DropColumn(
                name: "CapacidadAlmacenamiento",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "EsMultiPlataforma",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "Fabricante",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "FechaCompra",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "FechaVenta",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "IdConsolasP",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "IdControles",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "IdVideoJuego",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "NumeroControles",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "PrecioCompra",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "PrecioVenta",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "TipoAlmacenamiento",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "TipoControl",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "VelocidadProcesamiento",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "VelocidadRam",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "VideoJuego_Fabricante",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "VideoJuego_Nombre",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "VideoJuego_Version",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "EmpleadosId",
                table: "facturas");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "Contrasenna",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "Sucursal",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "TipoEmpleado",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "empleados");
        }
    }
}
