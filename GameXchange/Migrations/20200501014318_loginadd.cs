using Microsoft.EntityFrameworkCore.Migrations;

namespace GameXchange.Migrations
{
    public partial class loginadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoginDate",
                table: "AccountDbGenerator",
                type: "varchar(30)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginDate",
                table: "AccountDbGenerator");
        }
    }
}
