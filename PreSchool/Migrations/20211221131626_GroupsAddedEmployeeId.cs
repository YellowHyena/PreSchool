using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreSchool.Migrations
{
    public partial class GroupsAddedEmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "Children");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_EmployeeId",
                table: "Groups",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Employees_EmployeeId",
                table: "Groups",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Employees_EmployeeId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_EmployeeId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Groups");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Children",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
