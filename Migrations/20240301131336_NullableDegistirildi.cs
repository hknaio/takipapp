using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class NullableDegistirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurEmanet_SpiralBoru_SpiralBoruId",
                table: "PurEmanet");

            migrationBuilder.AlterColumn<int>(
                name: "SpiralBoruId",
                table: "PurEmanet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PurEmanet_SpiralBoru_SpiralBoruId",
                table: "PurEmanet",
                column: "SpiralBoruId",
                principalTable: "SpiralBoru",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurEmanet_SpiralBoru_SpiralBoruId",
                table: "PurEmanet");

            migrationBuilder.AlterColumn<int>(
                name: "SpiralBoruId",
                table: "PurEmanet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PurEmanet_SpiralBoru_SpiralBoruId",
                table: "PurEmanet",
                column: "SpiralBoruId",
                principalTable: "SpiralBoru",
                principalColumn: "ID");
        }
    }
}
