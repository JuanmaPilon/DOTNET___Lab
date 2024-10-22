using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_950 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Puesto_PuestoAsignadoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PuestoAsignadoId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "PuestoNroPuesto",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PuestoNroPuesto",
                table: "Usuario",
                column: "PuestoNroPuesto");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Puesto_PuestoNroPuesto",
                table: "Usuario",
                column: "PuestoNroPuesto",
                principalTable: "Puesto",
                principalColumn: "NroPuesto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Puesto_PuestoNroPuesto",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PuestoNroPuesto",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PuestoNroPuesto",
                table: "Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PuestoAsignadoId",
                table: "Usuario",
                column: "PuestoAsignadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Puesto_PuestoAsignadoId",
                table: "Usuario",
                column: "PuestoAsignadoId",
                principalTable: "Puesto",
                principalColumn: "NroPuesto",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
