using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePuremanetForIsMakinesiOperatorTalepEden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsMakinesi",
                table: "PurEmanet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Operator",
                table: "PurEmanet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TalepEdenPersonel",
                table: "PurEmanet",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMakinesi",
                table: "PurEmanet");

            migrationBuilder.DropColumn(
                name: "Operator",
                table: "PurEmanet");

            migrationBuilder.DropColumn(
                name: "TalepEdenPersonel",
                table: "PurEmanet");
        }
    }
}
