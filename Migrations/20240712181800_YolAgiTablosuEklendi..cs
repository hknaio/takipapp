using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class YolAgiTablosuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YolAgi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BSK = table.Column<double>(type: "float", nullable: false),
                    Asfalt = table.Column<double>(type: "float", nullable: false),
                    Stabilize = table.Column<double>(type: "float", nullable: false),
                    KilitParke = table.Column<double>(type: "float", nullable: false),
                    BetonYol = table.Column<double>(type: "float", nullable: false),
                    ToplamAg = table.Column<double>(type: "float", nullable: false),
                    IlceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YolAgi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_YolAgi_Ilce_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilce",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YolAgi_IlceID",
                table: "YolAgi",
                column: "IlceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YolAgi");
        }
    }
}
