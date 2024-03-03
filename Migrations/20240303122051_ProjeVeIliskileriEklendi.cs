using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class ProjeVeIliskileriEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjeID",
                table: "YatirimProgrami",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uygulama",
                table: "YatirimProgrami",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YaklasikMaliyet",
                table: "YatirimProgrami",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Proje",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IseBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sure = table.Column<int>(type: "int", nullable: false),
                    Yuklenici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeciciKabulTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KesinKabulTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjeDurumu = table.Column<int>(type: "int", nullable: false),
                    SozlesmeBedeli = table.Column<double>(type: "float", nullable: false),
                    YaklasikMaliyet = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proje", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hakedis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    ProjeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakedis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hakedis_Proje_ProjeID",
                        column: x => x.ProjeID,
                        principalTable: "Proje",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YatirimProgrami_ProjeID",
                table: "YatirimProgrami",
                column: "ProjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Hakedis_ProjeID",
                table: "Hakedis",
                column: "ProjeID");

            migrationBuilder.AddForeignKey(
                name: "FK_YatirimProgrami_Proje_ProjeID",
                table: "YatirimProgrami",
                column: "ProjeID",
                principalTable: "Proje",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YatirimProgrami_Proje_ProjeID",
                table: "YatirimProgrami");

            migrationBuilder.DropTable(
                name: "Hakedis");

            migrationBuilder.DropTable(
                name: "Proje");

            migrationBuilder.DropIndex(
                name: "IX_YatirimProgrami_ProjeID",
                table: "YatirimProgrami");

            migrationBuilder.DropColumn(
                name: "ProjeID",
                table: "YatirimProgrami");

            migrationBuilder.DropColumn(
                name: "Uygulama",
                table: "YatirimProgrami");

            migrationBuilder.DropColumn(
                name: "YaklasikMaliyet",
                table: "YatirimProgrami");
        }
    }
}
