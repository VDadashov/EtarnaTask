using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etarna.Migrations
{
    public partial class UpdatePortfolioDetailAndClientAndImageRelated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages");

            migrationBuilder.DropColumn(
                name: "PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioImageId",
                table: "PortfolioDetailAndClientAndImageRelationManyToManies",
                column: "PortfolioImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioImages_PortfolioImageId",
                table: "PortfolioDetailAndClientAndImageRelationManyToManies",
                column: "PortfolioImageId",
                principalTable: "PortfolioImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioImages_PortfolioImageId",
                table: "PortfolioDetailAndClientAndImageRelationManyToManies");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioImageId",
                table: "PortfolioDetailAndClientAndImageRelationManyToManies");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages",
                column: "PortfolioDetailAndClientAndImageRelationManyToManyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages",
                column: "PortfolioDetailAndClientAndImageRelationManyToManyId",
                principalTable: "PortfolioDetailAndClientAndImageRelationManyToManies",
                principalColumn: "Id");
        }
    }
}
