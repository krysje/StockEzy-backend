using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockAPI.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sector",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    Company_Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Turnover = table.Column<float>(type: "real", nullable: false),
                    CEO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardOfDirectors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectorId = table.Column<long>(type: "bigint", nullable: false),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Company_Code);
                    table.ForeignKey(
                        name: "FK_company_sector_SectorId",
                        column: x => x.SectorId,
                        principalTable: "sector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stock_exchange",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_exchange", x => x.Name);
                    table.ForeignKey(
                        name: "FK_stock_exchange_company_CompanyCode",
                        column: x => x.CompanyCode,
                        principalTable: "company",
                        principalColumn: "Company_Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ipo_details",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StockExchange = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PricePerShare = table.Column<float>(type: "real", nullable: false),
                    TotalShares = table.Column<long>(type: "bigint", nullable: false),
                    OpenDateTime = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ipo_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ipo_details_company_CompanyCode",
                        column: x => x.CompanyCode,
                        principalTable: "company",
                        principalColumn: "Company_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ipo_details_stock_exchange_StockExchange",
                        column: x => x.StockExchange,
                        principalTable: "stock_exchange",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "stock",
                columns: table => new
                {
                    Stock_Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StockExchange = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CurrentPrice = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock", x => x.Stock_Code);
                    table.ForeignKey(
                        name: "FK_stock_company_CompanyCode",
                        column: x => x.CompanyCode,
                        principalTable: "company",
                        principalColumn: "Company_Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_stock_stock_exchange_StockExchange",
                        column: x => x.StockExchange,
                        principalTable: "stock_exchange",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_company_SectorId",
                table: "company",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ipo_details_CompanyCode",
                table: "ipo_details",
                column: "CompanyCode");

            migrationBuilder.CreateIndex(
                name: "IX_ipo_details_StockExchange",
                table: "ipo_details",
                column: "StockExchange");

            migrationBuilder.CreateIndex(
                name: "IX_stock_CompanyCode",
                table: "stock",
                column: "CompanyCode");

            migrationBuilder.CreateIndex(
                name: "IX_stock_StockExchange",
                table: "stock",
                column: "StockExchange");

            migrationBuilder.CreateIndex(
                name: "IX_stock_exchange_CompanyCode",
                table: "stock_exchange",
                column: "CompanyCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ipo_details");

            migrationBuilder.DropTable(
                name: "stock");

            migrationBuilder.DropTable(
                name: "stock_exchange");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "sector");
        }
    }
}
