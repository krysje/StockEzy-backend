using Microsoft.EntityFrameworkCore.Migrations;

namespace StockAPI.Migrations
{
    public partial class changedBOD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stock_exchange_company_CompanyCode",
                table: "stock_exchange");

            migrationBuilder.DropIndex(
                name: "IX_stock_exchange_CompanyCode",
                table: "stock_exchange");

            migrationBuilder.DropColumn(
                name: "CompanyCode",
                table: "stock_exchange");

            migrationBuilder.AddColumn<string>(
                name: "ListedinStockExchanges",
                table: "company",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListedinStockExchanges",
                table: "company");

            migrationBuilder.AddColumn<string>(
                name: "CompanyCode",
                table: "stock_exchange",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_stock_exchange_CompanyCode",
                table: "stock_exchange",
                column: "CompanyCode");

            migrationBuilder.AddForeignKey(
                name: "FK_stock_exchange_company_CompanyCode",
                table: "stock_exchange",
                column: "CompanyCode",
                principalTable: "company",
                principalColumn: "Company_Code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
