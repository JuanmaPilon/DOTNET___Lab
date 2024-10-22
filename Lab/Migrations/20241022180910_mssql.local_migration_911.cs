using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_911 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroOperario",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PuestoAsignadoId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "Usuario",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Puesto_PuestoAsignadoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PuestoAsignadoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "NumeroOperario",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PuestoAsignadoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Usuario");
        }
    }
}
