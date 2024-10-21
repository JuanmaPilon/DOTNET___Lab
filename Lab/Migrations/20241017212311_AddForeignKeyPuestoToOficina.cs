using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyPuestoToOficina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Oficina_OficinaidOficina",
                table: "Puesto");

            migrationBuilder.DropIndex(
                name: "IX_Puesto_OficinaidOficina",
                table: "Puesto");

            migrationBuilder.DropColumn(
                name: "OficinaidOficina",
                table: "Puesto");

            migrationBuilder.AddColumn<int>(
                name: "idOficina",
                table: "Puesto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_idOficina",
                table: "Puesto",
                column: "idOficina");

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_Oficina_idOficina",
                table: "Puesto",
                column: "idOficina",
                principalTable: "Oficina",
                principalColumn: "idOficina",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Puesto_Oficina_idOficina",
                table: "Puesto");

            migrationBuilder.DropIndex(
                name: "IX_Puesto_idOficina",
                table: "Puesto");

            migrationBuilder.DropColumn(
                name: "idOficina",
                table: "Puesto");

            migrationBuilder.AddColumn<int>(
                name: "OficinaidOficina",
                table: "Puesto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_OficinaidOficina",
                table: "Puesto",
                column: "OficinaidOficina");

            migrationBuilder.AddForeignKey(
                name: "FK_Puesto_Oficina_OficinaidOficina",
                table: "Puesto",
                column: "OficinaidOficina",
                principalTable: "Oficina",
                principalColumn: "idOficina");
        }
    }
}
