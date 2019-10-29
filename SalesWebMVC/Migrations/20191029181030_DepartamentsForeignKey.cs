using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class DepartamentsForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departaments_DepartamentId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartamentId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentsId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartamentsId",
                table: "Seller",
                column: "DepartamentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departaments_DepartamentsId",
                table: "Seller",
                column: "DepartamentsId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departaments_DepartamentsId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartamentsId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartamentsId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "Seller",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartamentId",
                table: "Seller",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departaments_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
