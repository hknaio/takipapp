using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class SpiralBoruPurEmanetIliskisiEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpiralBoruId",
                table: "PurEmanet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurEmanet_SpiralBoruId",
                table: "PurEmanet",
                column: "SpiralBoruId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurEmanet_SpiralBoru_SpiralBoruId",
                table: "PurEmanet",
                column: "SpiralBoruId",
                principalTable: "SpiralBoru",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurEmanet_SpiralBoru_SpiralBoruId",
                table: "PurEmanet");

            migrationBuilder.DropIndex(
                name: "IX_PurEmanet_SpiralBoruId",
                table: "PurEmanet");

            migrationBuilder.DropColumn(
                name: "SpiralBoruId",
                table: "PurEmanet");
        }
    }
}
