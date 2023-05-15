using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etarna.Migrations
{
    public partial class PortfolioDetailAndClientAndImageRelated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PortfolioDetailAndClientAndImageRelationManyToManies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioDetailId = table.Column<int>(type: "int", nullable: false),
                    PortfolioImageId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioDetailAndClientAndImageRelationManyToManies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortfolioDetailAndClientAndImageRelationManyToManies_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioDetails_PortfolioDetailId",
                        column: x => x.PortfolioDetailId,
                        principalTable: "PortfolioDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages",
                column: "PortfolioDetailAndClientAndImageRelationManyToManyId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioDetailAndClientAndImageRelationManyToManies_ClientId",
                table: "PortfolioDetailAndClientAndImageRelationManyToManies",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioDetailId",
                table: "PortfolioDetailAndClientAndImageRelationManyToManies",
                column: "PortfolioDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages",
                column: "PortfolioDetailAndClientAndImageRelationManyToManyId",
                principalTable: "PortfolioDetailAndClientAndImageRelationManyToManies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManies_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages");

            migrationBuilder.DropTable(
                name: "PortfolioDetailAndClientAndImageRelationManyToManies");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioImages_PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages");

            migrationBuilder.DropColumn(
                name: "PortfolioDetailAndClientAndImageRelationManyToManyId",
                table: "PortfolioImages");
        }
    }
}
