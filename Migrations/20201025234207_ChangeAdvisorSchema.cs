using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvisorRegistrationWebApi.Migrations
{
    public partial class ChangeAdvisorSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "memberSince",
                table: "Advisors");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Advisors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "memberSince",
                table: "Advisors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Advisors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
