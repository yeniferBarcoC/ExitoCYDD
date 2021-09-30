using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class ActualizarCrud : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facturas_empleados_EmpleadosId",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_facturas_FacturasId",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_facturas",
                table: "facturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empleados",
                table: "empleados");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "facturas",
                newName: "Facturas");

            migrationBuilder.RenameTable(
                name: "empleados",
                newName: "Empleados");

            migrationBuilder.RenameIndex(
                name: "IX_productos_FacturasId",
                table: "Productos",
                newName: "IX_Productos_FacturasId");

            migrationBuilder.RenameIndex(
                name: "IX_facturas_EmpleadosId",
                table: "Facturas",
                newName: "IX_Facturas_EmpleadosId");

            migrationBuilder.AddColumn<int>(
                name: "TipoProducto",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ProductoId",
                table: "Facturas",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Empleados_EmpleadosId",
                table: "Facturas",
                column: "EmpleadosId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Productos_ProductoId",
                table: "Facturas",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Facturas_FacturasId",
                table: "Productos",
                column: "FacturasId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Empleados_EmpleadosId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Productos_ProductoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Facturas_FacturasId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_ProductoId",
                table: "Facturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "TipoProducto",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Facturas");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "productos");

            migrationBuilder.RenameTable(
                name: "Facturas",
                newName: "facturas");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "empleados");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_FacturasId",
                table: "productos",
                newName: "IX_productos_FacturasId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_EmpleadosId",
                table: "facturas",
                newName: "IX_facturas_EmpleadosId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos",
                table: "productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_facturas",
                table: "facturas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empleados",
                table: "empleados",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_empleados_EmpleadosId",
                table: "facturas",
                column: "EmpleadosId",
                principalTable: "empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_productos_facturas_FacturasId",
                table: "productos",
                column: "FacturasId",
                principalTable: "facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
