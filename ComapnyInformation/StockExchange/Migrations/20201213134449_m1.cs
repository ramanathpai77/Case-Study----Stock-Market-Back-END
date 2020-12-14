using Microsoft.EntityFrameworkCore.Migrations;

namespace StockExchange.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockExchanges",
                columns: table => new
                {
                    SEId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockExchanges", x => x.SEId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Turnover = table.Column<double>(type: "float", nullable: false),
                    CEO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CCode);
                    table.ForeignKey(
                        name: "FK_Company_StockExchanges_SEId",
                        column: x => x.SEId,
                        principalTable: "StockExchanges",
                        principalColumn: "SEId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_SEId",
                table: "Company",
                column: "SEId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "StockExchanges");
        }
    }
}
