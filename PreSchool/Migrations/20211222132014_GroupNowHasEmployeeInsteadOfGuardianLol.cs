using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreSchool.Migrations
{
    public partial class GroupNowHasEmployeeInsteadOfGuardianLol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Employees_EmployeeId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Guardians_Groups_GroupId",
                table: "Guardians");

            migrationBuilder.DropIndex(
                name: "IX_Guardians_GroupId",
                table: "Guardians");

            migrationBuilder.DropIndex(
                name: "IX_Groups_EmployeeId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Guardians");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Groups");

            migrationBuilder.CreateTable(
                name: "EmployeeGroup",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    GroupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeGroup", x => new { x.EmployeesId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_EmployeeGroup_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeGroup_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGroup_GroupsId",
                table: "EmployeeGroup",
                column: "GroupsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeGroup");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Guardians",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_GroupId",
                table: "Guardians",
                column: "GroupId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Guardians_Groups_GroupId",
                table: "Guardians",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }
    }
}
