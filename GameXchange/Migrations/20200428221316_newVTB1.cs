using Microsoft.EntityFrameworkCore.Migrations;

namespace GameXchange.Migrations
{
    public partial class newVTB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountDbGenerator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    AccountType = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    PaymentInfo = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountDbGenerator", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountDbGenerator");
        }
    }
}
