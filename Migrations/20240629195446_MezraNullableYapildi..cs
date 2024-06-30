using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class MezraNullableYapildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsfaltSantiye_Mezra_MezraId",
                table: "AsfaltSantiye");

            migrationBuilder.AlterColumn<int>(
                name: "MezraId",
                table: "AsfaltSantiye",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AsfaltSantiye_Mezra_MezraId",
                table: "AsfaltSantiye",
                column: "MezraId",
                principalTable: "Mezra",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsfaltSantiye_Mezra_MezraId",
                table: "AsfaltSantiye");

            migrationBuilder.AlterColumn<int>(
                name: "MezraId",
                table: "AsfaltSantiye",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AsfaltSantiye_Mezra_MezraId",
                table: "AsfaltSantiye",
                column: "MezraId",
                principalTable: "Mezra",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
