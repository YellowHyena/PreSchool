using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreSchool.Migrations
{
    public partial class firstmaybe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressInfo_Adults_AdultId",
                table: "AddressInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_AdultChild_Adults_AdultsId",
                table: "AdultChild");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdultChild",
                table: "AdultChild");

            migrationBuilder.DropIndex(
                name: "IX_AdultChild_ChildrenId",
                table: "AdultChild");

            migrationBuilder.DropColumn(
                name: "Group1",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Group2",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "BillRecipent",
                table: "Adults");

            migrationBuilder.RenameColumn(
                name: "Group3",
                table: "Groups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AdultsId",
                table: "AdultChild",
                newName: "GuardiansId");

            migrationBuilder.AddColumn<int>(
                name: "BillRecipent",
                table: "Children",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Adults",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdultId",
                table: "AddressInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GuardianId",
                table: "AddressInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdultChild",
                table: "AdultChild",
                columns: new[] { "ChildrenId", "GuardiansId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Adults_GroupId",
                table: "Adults",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AdultChild_GuardiansId",
                table: "AdultChild",
                column: "GuardiansId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildGroup_GroupsId",
                table: "ChildGroup",
                column: "GroupsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressInfo_Adults_AdultId",
                table: "AddressInfo",
                column: "AdultId",
                principalTable: "Adults",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdultChild_Adults_GuardiansId",
                table: "AdultChild",
                column: "GuardiansId",
                principalTable: "Adults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adults_Groups_GroupId",
                table: "Adults",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressInfo_Adults_AdultId",
                table: "AddressInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_AdultChild_Adults_GuardiansId",
                table: "AdultChild");

            migrationBuilder.DropForeignKey(
                name: "FK_Adults_Groups_GroupId",
                table: "Adults");

            migrationBuilder.DropTable(
                name: "ChildGroup");

            migrationBuilder.DropIndex(
                name: "IX_Adults_GroupId",
                table: "Adults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdultChild",
                table: "AdultChild");

            migrationBuilder.DropIndex(
                name: "IX_AdultChild_GuardiansId",
                table: "AdultChild");

            migrationBuilder.DropColumn(
                name: "BillRecipent",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Adults");

            migrationBuilder.DropColumn(
                name: "GuardianId",
                table: "AddressInfo");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Groups",
                newName: "Group3");

            migrationBuilder.RenameColumn(
                name: "GuardiansId",
                table: "AdultChild",
                newName: "AdultsId");

            migrationBuilder.AddColumn<string>(
                name: "Group1",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Group2",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Children",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BillRecipent",
                table: "Adults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AdultId",
                table: "AddressInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdultChild",
                table: "AdultChild",
                columns: new[] { "AdultsId", "ChildrenId" });

            migrationBuilder.CreateIndex(
                name: "IX_AdultChild_ChildrenId",
                table: "AdultChild",
                column: "ChildrenId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressInfo_Adults_AdultId",
                table: "AddressInfo",
                column: "AdultId",
                principalTable: "Adults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdultChild_Adults_AdultsId",
                table: "AdultChild",
                column: "AdultsId",
                principalTable: "Adults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
