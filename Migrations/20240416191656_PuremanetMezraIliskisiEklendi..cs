using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class PuremanetMezraIliskisiEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurEmanetMezra",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurEmanetId = table.Column<int>(type: "int", nullable: false),
                    MezraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurEmanetMezra", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurEmanetMezra_Mezra_MezraId",
                        column: x => x.MezraId,
                        principalTable: "Mezra",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurEmanetMezra_PurEmanet_PurEmanetId",
                        column: x => x.PurEmanetId,
                        principalTable: "PurEmanet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanetMezra_MezraId",
                table: "PurEmanetMezra",
                column: "MezraId");

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanetMezra_PurEmanetId",
                table: "PurEmanetMezra",
                column: "PurEmanetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurEmanetMezra");
        }
    }
}
