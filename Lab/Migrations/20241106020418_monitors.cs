using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Migrations
{
    /// <inheritdoc />
    public partial class monitors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonitoridMonitor",
                table: "Tramite",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Monitor",
                columns: table => new
                {
                    idMonitor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idOficina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitor", x => x.idMonitor);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tramite_MonitoridMonitor",
                table: "Tramite",
                column: "MonitoridMonitor");

            migrationBuilder.AddForeignKey(
                name: "FK_Tramite_Monitor_MonitoridMonitor",
                table: "Tramite",
                column: "MonitoridMonitor",
                principalTable: "Monitor",
                principalColumn: "idMonitor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tramite_Monitor_MonitoridMonitor",
                table: "Tramite");

            migrationBuilder.DropTable(
                name: "Monitor");

            migrationBuilder.DropIndex(
                name: "IX_Tramite_MonitoridMonitor",
                table: "Tramite");

            migrationBuilder.DropColumn(
                name: "MonitoridMonitor",
                table: "Tramite");
        }
    }
}
