using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oficina",
                columns: table => new
                {
                    idOficina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficina", x => x.idOficina);
                });

            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    NroPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    TramiteActual = table.Column<int>(type: "int", nullable: false),
                    OficinaidOficina = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.NroPuesto);
                    table.ForeignKey(
                        name: "FK_Puesto_Oficina_OficinaidOficina",
                        column: x => x.OficinaidOficina,
                        principalTable: "Oficina",
                        principalColumn: "idOficina");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_OficinaidOficina",
                table: "Puesto",
                column: "OficinaidOficina");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Puesto");

            migrationBuilder.DropTable(
                name: "Oficina");
        }
    }
}
