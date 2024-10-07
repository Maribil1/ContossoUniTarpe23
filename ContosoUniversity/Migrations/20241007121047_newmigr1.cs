using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class newmigr1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Departments_DepartmentsDepartmentID",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "DepartmentsDepartmentID",
                table: "Course",
                newName: "DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentsDepartmentID",
                table: "Course",
                newName: "IX_Course_DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Departments_DepartmentID",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Course",
                newName: "DepartmentsDepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DepartmentID",
                table: "Course",
                newName: "IX_Course_DepartmentsDepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Departments_DepartmentsDepartmentID",
                table: "Course",
                column: "DepartmentsDepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");
        }
    }
}
