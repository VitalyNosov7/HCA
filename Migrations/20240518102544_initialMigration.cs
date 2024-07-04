using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelCalcApp.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameHotel = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelServiceName = table.Column<string>(type: "TEXT", nullable: false),
                    IdHotel = table.Column<int>(type: "INTEGER", nullable: false),
                    HotelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelServices_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HotelServicePrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateActualPrice = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateStartPrice = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateEndPrice = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PriceService = table.Column<decimal>(type: "TEXT", nullable: false),
                    IdHotelService = table.Column<long>(type: "INTEGER", nullable: false),
                    HotelServiceId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServicePrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelServicePrice_HotelServices_HotelServiceId",
                        column: x => x.HotelServiceId,
                        principalTable: "HotelServices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelServicePrice_HotelServiceId",
                table: "HotelServicePrice",
                column: "HotelServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelServices_HotelId",
                table: "HotelServices",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelServicePrice");

            migrationBuilder.DropTable(
                name: "HotelServices");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
