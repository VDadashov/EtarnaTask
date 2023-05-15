using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etarna.Migrations
{
    public partial class UpdateImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "PortfolioImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "PortfolioImages");
        }
    }
}
