using Microsoft.EntityFrameworkCore.Migrations;

namespace UsernameAndPassword.Migrations
{
    public partial class migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoginmodelUserName",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LoginmodelUserName",
                table: "Employees",
                column: "LoginmodelUserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Logins_LoginmodelUserName",
                table: "Employees",
                column: "LoginmodelUserName",
                principalTable: "Logins",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Logins_LoginmodelUserName",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LoginmodelUserName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LoginmodelUserName",
                table: "Employees");
        }
    }
}
