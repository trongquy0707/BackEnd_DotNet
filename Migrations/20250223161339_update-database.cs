using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_my_pham.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaUser",
                table: "HOA_DON_CHI_TIET",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HOA_DON_CHI_TIET_MaUser",
                table: "HOA_DON_CHI_TIET",
                column: "MaUser");

            migrationBuilder.AddForeignKey(
                name: "FK_HOA_DON_CHI_TIET_TAI_KHOAN_MaUser",
                table: "HOA_DON_CHI_TIET",
                column: "MaUser",
                principalTable: "TAI_KHOAN",
                principalColumn: "MaUser",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HOA_DON_CHI_TIET_TAI_KHOAN_MaUser",
                table: "HOA_DON_CHI_TIET");

            migrationBuilder.DropIndex(
                name: "IX_HOA_DON_CHI_TIET_MaUser",
                table: "HOA_DON_CHI_TIET");

            migrationBuilder.DropColumn(
                name: "MaUser",
                table: "HOA_DON_CHI_TIET");
        }
    }
}
