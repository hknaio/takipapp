using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AsfaltUygulamaVeriEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsfaltUygulamaVeri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sure = table.Column<int>(type: "int", nullable: false),
                    YatirimProgramiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsfaltUygulamaVeri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AsfaltUygulamaVeri_YatirimProgrami_YatirimProgramiID",
                        column: x => x.YatirimProgramiID,
                        principalTable: "YatirimProgrami",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsfaltUygulamaVeri_YatirimProgramiID",
                table: "AsfaltUygulamaVeri",
                column: "YatirimProgramiID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsfaltUygulamaVeri");
        }
    }
}
