using Microsoft.EntityFrameworkCore.Migrations;

namespace UsernameAndPassword.Migrations
{
    public partial class migsal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Employees_Id",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Salaries");

            migrationBuilder.AlterColumn<int>(
                name: "Salary_id",
                table: "Salaries",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Salaries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "employeeid",
                table: "Salaries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "employeeid",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Salary_id");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_employeeid",
                table: "Salaries",
                column: "employeeid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_employeeid",
                table: "Employees",
                column: "employeeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_employeeid",
                table: "Employees",
                column: "employeeid",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Employees_employeeid",
                table: "Salaries",
                column: "employeeid",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_employeeid",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Employees_employeeid",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_Salaries_employeeid",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_Employees_employeeid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "employeeid",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "employeeid",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Salary_id",
                table: "Salaries",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Salaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Employees_Id",
                table: "Salaries",
                column: "Id",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
