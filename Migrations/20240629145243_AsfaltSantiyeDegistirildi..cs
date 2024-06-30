using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AsfaltSantiyeDegistirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Koy1",
                table: "AsfaltSantiye");

            migrationBuilder.DropColumn(
                name: "Koy2",
                table: "AsfaltSantiye");

            migrationBuilder.DropColumn(
                name: "Koy3",
                table: "AsfaltSantiye");

            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "AsfaltSantiye",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KoyId",
                table: "AsfaltSantiye",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MezraId",
                table: "AsfaltSantiye",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AsfaltSantiye_IlceId",
                table: "AsfaltSantiye",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_AsfaltSantiye_KoyId",
                table: "AsfaltSantiye",
                column: "KoyId");

            migrationBuilder.CreateIndex(
                name: "IX_AsfaltSantiye_MezraId",
                table: "AsfaltSantiye",
                column: "MezraId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsfaltSantiye_Ilce_IlceId",
                table: "AsfaltSantiye",
                column: "IlceId",
                principalTable: "Ilce",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AsfaltSantiye_Koy_KoyId",
                table: "AsfaltSantiye",
                column: "KoyId",
                principalTable: "Koy",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AsfaltSantiye_Mezra_MezraId",
                table: "AsfaltSantiye",
                column: "MezraId",
                principalTable: "Mezra",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsfaltSantiye_Ilce_IlceId",
                table: "AsfaltSantiye");

            migrationBuilder.DropForeignKey(
                name: "FK_AsfaltSantiye_Koy_KoyId",
                table: "AsfaltSantiye");

            migrationBuilder.DropForeignKey(
                name: "FK_AsfaltSantiye_Mezra_MezraId",
                table: "AsfaltSantiye");

            migrationBuilder.DropIndex(
                name: "IX_AsfaltSantiye_IlceId",
                table: "AsfaltSantiye");

            migrationBuilder.DropIndex(
                name: "IX_AsfaltSantiye_KoyId",
                table: "AsfaltSantiye");

            migrationBuilder.DropIndex(
                name: "IX_AsfaltSantiye_MezraId",
                table: "AsfaltSantiye");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "AsfaltSantiye");

            migrationBuilder.DropColumn(
                name: "KoyId",
                table: "AsfaltSantiye");

            migrationBuilder.DropColumn(
                name: "MezraId",
                table: "AsfaltSantiye");

            migrationBuilder.AddColumn<string>(
                name: "Koy1",
                table: "AsfaltSantiye",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Koy2",
                table: "AsfaltSantiye",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Koy3",
                table: "AsfaltSantiye",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
