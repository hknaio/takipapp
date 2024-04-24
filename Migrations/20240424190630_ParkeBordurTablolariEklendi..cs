using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class ParkeBordurTablolariEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkeBordur",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Malzeme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StokMiktar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkeBordur", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ParkeBordurIs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepEden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GidisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AracPlakasi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkeBordurIs", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkeBordur");

            migrationBuilder.DropTable(
                name: "ParkeBordurIs");
        }
    }
}
