using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class GereksizNavPropertyKaldirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PurEmanet_IlceId",
                table: "PurEmanet");

            migrationBuilder.DropIndex(
                name: "IX_PurEmanet_ImalatId",
                table: "PurEmanet");

            migrationBuilder.DropIndex(
                name: "IX_PurEmanet_KoyId",
                table: "PurEmanet");

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanet_IlceId",
                table: "PurEmanet",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanet_ImalatId",
                table: "PurEmanet",
                column: "ImalatId");

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanet_KoyId",
                table: "PurEmanet",
                column: "KoyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PurEmanet_IlceId",
                table: "PurEmanet");

            migrationBuilder.DropIndex(
                name: "IX_PurEmanet_ImalatId",
                table: "PurEmanet");

            migrationBuilder.DropIndex(
                name: "IX_PurEmanet_KoyId",
                table: "PurEmanet");

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
    }
}
