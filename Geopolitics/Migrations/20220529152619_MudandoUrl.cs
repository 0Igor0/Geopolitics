using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Geopolitics.Migrations
{
    public partial class MudandoUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE dbo.Countries SET ImgUrl = '/images/brasil.jpg' WHERE ImgUrl = '~/images/brasil.jpg';");
            migrationBuilder.Sql("UPDATE dbo.Countries SET ImgUrl = '/images/israel.jpg' WHERE ImgUrl = '~/images/israel.jpg';");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Countries");
        }
    }
}
