using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CA_FacultyDbCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AcademicStaffAndCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credit = table.Column<short>(type: "smallint", nullable: false),
                    Ects = table.Column<short>(type: "smallint", nullable: false),
                    NumberOfStudent = table.Column<int>(type: "int", nullable: false),
                    NumberOfAcademicStaff = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseAndAcademicStaff",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    AcademicStaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAndAcademicStaff", x => new { x.CourseId, x.AcademicStaffId });
                    table.ForeignKey(
                        name: "FK_CourseAndAcademicStaff_AcademicStaff_AcademicStaffId",
                        column: x => x.AcademicStaffId,
                        principalTable: "AcademicStaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseAndAcademicStaff_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseAndAcademicStaff_AcademicStaffId",
                table: "CourseAndAcademicStaff",
                column: "AcademicStaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseAndAcademicStaff");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
