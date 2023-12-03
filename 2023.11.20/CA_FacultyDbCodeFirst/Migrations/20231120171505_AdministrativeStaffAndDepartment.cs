using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CA_FacultyDbCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AdministrativeStaffAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialClubAndStudent_MyProperty_SocialClubId",
                table: "SocialClubAndStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "SocialClubs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialClubs",
                table: "SocialClubs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AdministrativeStaffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativeStaffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdministrativeStaffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeStaffs_DepartmentId",
                table: "AdministrativeStaffs",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialClubAndStudent_SocialClubs_SocialClubId",
                table: "SocialClubAndStudent",
                column: "SocialClubId",
                principalTable: "SocialClubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialClubAndStudent_SocialClubs_SocialClubId",
                table: "SocialClubAndStudent");

            migrationBuilder.DropTable(
                name: "AdministrativeStaffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialClubs",
                table: "SocialClubs");

            migrationBuilder.RenameTable(
                name: "SocialClubs",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialClubAndStudent_MyProperty_SocialClubId",
                table: "SocialClubAndStudent",
                column: "SocialClubId",
                principalTable: "MyProperty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
