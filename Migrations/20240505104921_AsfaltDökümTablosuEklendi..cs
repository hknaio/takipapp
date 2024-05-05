using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AsfaltDökümTablosuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsfaltDokum",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AstarMiktari = table.Column<double>(type: "float", nullable: false),
                    YamaMiktari = table.Column<double>(type: "float", nullable: false),
                    AsfaltMiktari = table.Column<double>(type: "float", nullable: false),
                    DokumMesafesi = table.Column<double>(type: "float", nullable: false),
                    DokumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DokumBedeli = table.Column<double>(type: "float", nullable: false),
                    BSKMiktari = table.Column<double>(type: "float", nullable: false),
                    YatirimProgramiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsfaltDokum", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AsfaltDokum_YatirimProgrami_YatirimProgramiID",
                        column: x => x.YatirimProgramiID,
                        principalTable: "YatirimProgrami",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsfaltDokum_YatirimProgramiID",
                table: "AsfaltDokum",
                column: "YatirimProgramiID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsfaltDokum");
        }
    }
}
