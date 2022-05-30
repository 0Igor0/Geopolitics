using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Geopolitics.Migrations
{
    public partial class SelectedCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SelectedCountries",
                columns: table => new
                {
                    SelectedCountriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Ammount = table.Column<int>(type: "int", nullable: false),
                    SelectedId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedCountries", x => x.SelectedCountriesId);
                    table.ForeignKey(
                        name: "FK_SelectedCountries_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedCountries_CountryId",
                table: "SelectedCountries",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedCountries");
        }
    }
}
