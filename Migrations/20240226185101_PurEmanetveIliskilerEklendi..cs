using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class PurEmanetveIliskilerEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurEmanet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    KoyId = table.Column<int>(type: "int", nullable: false),
                    ImalatId = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    Tutar = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurEmanet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurEmanet_Ilce_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilce",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurEmanet_Imalat_ImalatId",
                        column: x => x.ImalatId,
                        principalTable: "Imalat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PurEmanet_Koy_KoyId",
                        column: x => x.KoyId,
                        principalTable: "Koy",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanet_IlceId",
                table: "PurEmanet",
                column: "IlceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanet_ImalatId",
                table: "PurEmanet",
                column: "ImalatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanet_KoyId",
                table: "PurEmanet",
                column: "KoyId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurEmanet");
        }
    }
}
