using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CA_FacultyDbCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentAndStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAndAcademicStaff_AcademicStaff_AcademicStaffId",
                table: "CourseAndAcademicStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentAndAcademicStaff_AcademicStaff_AcademicStaffId",
                table: "DepartmentAndAcademicStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentAndAcademicStaff_Department_DepartmentId",
                table: "DepartmentAndAcademicStaff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicStaff",
                table: "AcademicStaff");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "AcademicStaff",
                newName: "AcademicStaffs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicStaffs",
                table: "AcademicStaffs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DepartmentAndStudent",
                columns: table => new
                {
                    DeparmantId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentAndStudent", x => new { x.DeparmantId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_DepartmentAndStudent_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentAndStudent_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentAndStudent_DepartmentId",
                table: "DepartmentAndStudent",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentAndStudent_StudentId",
                table: "DepartmentAndStudent",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAndAcademicStaff_AcademicStaffs_AcademicStaffId",
                table: "CourseAndAcademicStaff",
                column: "AcademicStaffId",
                principalTable: "AcademicStaffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentAndAcademicStaff_AcademicStaffs_AcademicStaffId",
                table: "DepartmentAndAcademicStaff",
                column: "AcademicStaffId",
                principalTable: "AcademicStaffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentAndAcademicStaff_Departments_DepartmentId",
                table: "DepartmentAndAcademicStaff",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAndAcademicStaff_AcademicStaffs_AcademicStaffId",
                table: "CourseAndAcademicStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentAndAcademicStaff_AcademicStaffs_AcademicStaffId",
                table: "DepartmentAndAcademicStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentAndAcademicStaff_Departments_DepartmentId",
                table: "DepartmentAndAcademicStaff");

            migrationBuilder.DropTable(
                name: "DepartmentAndStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicStaffs",
                table: "AcademicStaffs");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "AcademicStaffs",
                newName: "AcademicStaff");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicStaff",
                table: "AcademicStaff",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAndAcademicStaff_AcademicStaff_AcademicStaffId",
                table: "CourseAndAcademicStaff",
                column: "AcademicStaffId",
                principalTable: "AcademicStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentAndAcademicStaff_AcademicStaff_AcademicStaffId",
                table: "DepartmentAndAcademicStaff",
                column: "AcademicStaffId",
                principalTable: "AcademicStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentAndAcademicStaff_Department_DepartmentId",
                table: "DepartmentAndAcademicStaff",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
