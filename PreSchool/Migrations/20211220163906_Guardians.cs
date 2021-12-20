using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreSchool.Migrations
{
    public partial class Guardians : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressInfo_Adults_AdultId",
                table: "AddressInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Children_Groups_GroupId",
                table: "Children");

            migrationBuilder.DropTable(
                name: "AdultChild");

            migrationBuilder.DropTable(
                name: "Adults");

            migrationBuilder.DropIndex(
                name: "IX_Children_GroupId",
                table: "Children");

            migrationBuilder.DropIndex(
                name: "IX_AddressInfo_AdultId",
                table: "AddressInfo");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "AdultId",
                table: "AddressInfo");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployementDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ChildGroup",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    GroupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildGroup", x => new { x.ChildrenId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_ChildGroup_Children_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildGroup_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guardians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalNumber = table.Column<long>(type: "bigint", nullable: false),
                    IncomeInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DebitFee = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guardians_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChildGuardian",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    GuardiansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildGuardian", x => new { x.ChildrenId, x.GuardiansId });
                    table.ForeignKey(
                        name: "FK_ChildGuardian_Children_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildGuardian_Guardians_GuardiansId",
                        column: x => x.GuardiansId,
                        principalTable: "Guardians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfo_GuardianId",
                table: "AddressInfo",
                column: "GuardianId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildGroup_GroupsId",
                table: "ChildGroup",
                column: "GroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildGuardian_GuardiansId",
                table: "ChildGuardian",
                column: "GuardiansId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_GroupId",
                table: "Guardians",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressInfo_Guardians_GuardianId",
                table: "AddressInfo",
                column: "GuardianId",
                principalTable: "Guardians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressInfo_Guardians_GuardianId",
                table: "AddressInfo");

            migrationBuilder.DropTable(
                name: "ChildGroup");

            migrationBuilder.DropTable(
                name: "ChildGuardian");

            migrationBuilder.DropTable(
                name: "Guardians");

            migrationBuilder.DropIndex(
                name: "IX_AddressInfo_GuardianId",
                table: "AddressInfo");

            migrationBuilder.DropColumn(
                name: "EmployementDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Children",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdultId",
                table: "AddressInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DebitFee = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    IncomeInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalNumber = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adults_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdultChild",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    GuardiansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdultChild", x => new { x.ChildrenId, x.GuardiansId });
                    table.ForeignKey(
                        name: "FK_AdultChild_Adults_GuardiansId",
                        column: x => x.GuardiansId,
                        principalTable: "Adults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdultChild_Children_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Children",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_GroupId",
                table: "Children",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressInfo_AdultId",
                table: "AddressInfo",
                column: "AdultId");

            migrationBuilder.CreateIndex(
                name: "IX_AdultChild_GuardiansId",
                table: "AdultChild",
                column: "GuardiansId");

            migrationBuilder.CreateIndex(
                name: "IX_Adults_GroupId",
                table: "Adults",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressInfo_Adults_AdultId",
                table: "AddressInfo",
                column: "AdultId",
                principalTable: "Adults",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Groups_GroupId",
                table: "Children",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }
    }
}
