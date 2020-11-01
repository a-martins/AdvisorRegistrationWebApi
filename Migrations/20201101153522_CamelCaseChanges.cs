using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvisorRegistrationWebApi.Migrations
{
    public partial class CamelCaseChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "registryNumber",
                table: "Advisors",
                newName: "RegistryNumber");

            migrationBuilder.RenameColumn(
                name: "mobile",
                table: "Advisors",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Advisors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Advisors",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Advisors",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistryNumber",
                table: "Advisors",
                newName: "registryNumber");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Advisors",
                newName: "mobile");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Advisors",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Advisors",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Advisors",
                newName: "id");
        }
    }
}
