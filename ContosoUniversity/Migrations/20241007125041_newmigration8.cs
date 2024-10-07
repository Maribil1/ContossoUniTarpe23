using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class newmigration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructor_InstructorID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentCleaner",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "Departments",
                type: "int",
                maxLength: 500,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructor_InstructorID",
                table: "Departments",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructor_InstructorID",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentCleaner",
                table: "Departments",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructor_InstructorID",
                table: "Departments",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID");
        }
    }
}
