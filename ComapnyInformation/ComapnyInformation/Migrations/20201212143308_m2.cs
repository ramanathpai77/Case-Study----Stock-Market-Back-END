using Microsoft.EntityFrameworkCore.Migrations;

namespace ComapnyInformation.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyCode",
                table: "StockPrice",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_CompanyCode",
                table: "StockPrice",
                column: "CompanyCode");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPrice_Company_CompanyCode",
                table: "StockPrice",
                column: "CompanyCode",
                principalTable: "Company",
                principalColumn: "CCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPrice_Company_CompanyCode",
                table: "StockPrice");

            migrationBuilder.DropIndex(
                name: "IX_StockPrice_CompanyCode",
                table: "StockPrice");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyCode",
                table: "StockPrice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
