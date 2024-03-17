using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class YaklasikMaliyetVeriTipiDeğiştirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "YaklasikMaliyet",
                table: "YatirimProgrami",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YaklasikMaliyet",
                table: "YatirimProgrami",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
