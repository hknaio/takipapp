using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class BirimFiyatGecerlilikTarihiEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FiyatGecerlilikBaslangicTarihi",
                table: "Imalat",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ImalatBirimFiyatTarihGecmisi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GecerlilikBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImalatID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImalatBirimFiyatTarihGecmisi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ImalatBirimFiyatTarihGecmisi_Imalat_ImalatID",
                        column: x => x.ImalatID,
                        principalTable: "Imalat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImalatBirimFiyatTarihGecmisi_ImalatID",
                table: "ImalatBirimFiyatTarihGecmisi",
                column: "ImalatID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImalatBirimFiyatTarihGecmisi");

            migrationBuilder.DropColumn(
                name: "FiyatGecerlilikBaslangicTarihi",
                table: "Imalat");
        }
    }
}
