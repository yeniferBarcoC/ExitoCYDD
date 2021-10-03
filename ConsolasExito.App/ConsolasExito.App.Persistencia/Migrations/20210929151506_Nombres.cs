using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsolasExito.App.Persistencia.Migrations
{
    public partial class Nombres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facturas_Empleados_EmpleadoId",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_facturas_productos_productoId",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_facturas_FacturaId",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_videoJuegos",
                table: "videoJuegos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_facturas",
                table: "facturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_controles",
                table: "controles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_consolas",
                table: "consolas");

            migrationBuilder.RenameTable(
                name: "videoJuegos",
                newName: "VideoJuegos");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "facturas",
                newName: "Facturas");

            migrationBuilder.RenameTable(
                name: "controles",
                newName: "Controles");

            migrationBuilder.RenameTable(
                name: "consolas",
                newName: "Consolas");

            migrationBuilder.RenameIndex(
                name: "IX_productos_FacturaId",
                table: "Productos",
                newName: "IX_Productos_FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_facturas_productoId",
                table: "Facturas",
                newName: "IX_Facturas_productoId");

            migrationBuilder.RenameIndex(
                name: "IX_facturas_EmpleadoId",
                table: "Facturas",
                newName: "IX_Facturas_EmpleadoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoJuegos",
                table: "VideoJuegos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Controles",
                table: "Controles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consolas",
                table: "Consolas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Empleados_EmpleadoId",
                table: "Facturas",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Productos_productoId",
                table: "Facturas",
                column: "productoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Facturas_FacturaId",
                table: "Productos",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Empleados_EmpleadoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Productos_productoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Facturas_FacturaId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoJuegos",
                table: "VideoJuegos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Controles",
                table: "Controles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consolas",
                table: "Consolas");

            migrationBuilder.RenameTable(
                name: "VideoJuegos",
                newName: "videoJuegos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "productos");

            migrationBuilder.RenameTable(
                name: "Facturas",
                newName: "facturas");

            migrationBuilder.RenameTable(
                name: "Controles",
                newName: "controles");

            migrationBuilder.RenameTable(
                name: "Consolas",
                newName: "consolas");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_FacturaId",
                table: "productos",
                newName: "IX_productos_FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_productoId",
                table: "facturas",
                newName: "IX_facturas_productoId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_EmpleadoId",
                table: "facturas",
                newName: "IX_facturas_EmpleadoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_videoJuegos",
                table: "videoJuegos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos",
                table: "productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_facturas",
                table: "facturas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_controles",
                table: "controles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_consolas",
                table: "consolas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_Empleados_EmpleadoId",
                table: "facturas",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_productos_productoId",
                table: "facturas",
                column: "productoId",
                principalTable: "productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_productos_facturas_FacturaId",
                table: "productos",
                column: "FacturaId",
                principalTable: "facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
