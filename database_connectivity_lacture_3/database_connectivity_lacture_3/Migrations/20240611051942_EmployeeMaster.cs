using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace database_connectivity_lacture_3.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employeeMsts",
                table: "employeeMsts");

            migrationBuilder.DropColumn(
                name: "EmpEmail",
                table: "employeeMsts");

            migrationBuilder.DropColumn(
                name: "EmpMobile",
                table: "employeeMsts");

            migrationBuilder.DropColumn(
                name: "EmpName",
                table: "employeeMsts");

            migrationBuilder.RenameTable(
                name: "employeeMsts",
                newName: "employees");

            migrationBuilder.RenameColumn(
                name: "Emppassword",
                table: "employees",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Empid",
                table: "employees",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "employeeMsts");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "employeeMsts",
                newName: "Emppassword");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "employeeMsts",
                newName: "Empid");

            migrationBuilder.AddColumn<string>(
                name: "EmpEmail",
                table: "employeeMsts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmpMobile",
                table: "employeeMsts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmpName",
                table: "employeeMsts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employeeMsts",
                table: "employeeMsts",
                column: "Empid");
        }
    }
}
