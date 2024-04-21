using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class SpiralBoruBirimFiyatEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FiyatGecerlilikBaslangicTarihi",
                table: "SpiralBoru",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "SpiralBirimFiyatTarihGecmisis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GecerlilikBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirimFiyat = table.Column<double>(type: "float", nullable: false),
                    SpiralBoruID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpiralBirimFiyatTarihGecmisis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SpiralBirimFiyatTarihGecmisis_SpiralBoru_SpiralBoruID",
                        column: x => x.SpiralBoruID,
                        principalTable: "SpiralBoru",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpiralBirimFiyatTarihGecmisis_SpiralBoruID",
                table: "SpiralBirimFiyatTarihGecmisis",
                column: "SpiralBoruID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpiralBirimFiyatTarihGecmisis");

            migrationBuilder.DropColumn(
                name: "FiyatGecerlilikBaslangicTarihi",
                table: "SpiralBoru");
        }
    }
}
