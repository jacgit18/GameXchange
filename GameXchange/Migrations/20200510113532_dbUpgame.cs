using Microsoft.EntityFrameworkCore.Migrations;

namespace GameXchange.Migrations
{
    public partial class dbUpgame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    GameCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => x.GameCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "GameInfo",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    GameDescription = table.Column<string>(nullable: true),
                    GamePrice = table.Column<decimal>(nullable: false),
                    GameQuantity = table.Column<bool>(nullable: false),
                    GameCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameInfo", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_GameInfo_GameCategory_GameCategoryId",
                        column: x => x.GameCategoryId,
                        principalTable: "GameCategory",
                        principalColumn: "GameCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameInfo_GameCategoryId",
                table: "GameInfo",
                column: "GameCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameInfo");

            migrationBuilder.DropTable(
                name: "GameCategory");
        }
    }
}
