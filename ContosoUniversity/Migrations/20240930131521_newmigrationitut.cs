using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class newmigrationitut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FrenchDepartmentDescription",
                table: "Departments",
                newName: "DepartmentHead");

            migrationBuilder.RenameColumn(
                name: "DepartmentDescription",
                table: "Departments",
                newName: "DepartmentCleaner");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentHead",
                table: "Departments",
                newName: "FrenchDepartmentDescription");

            migrationBuilder.RenameColumn(
                name: "DepartmentCleaner",
                table: "Departments",
                newName: "DepartmentDescription");
        }
    }
}
