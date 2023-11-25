using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadastrofuncionariosback.Migrations
{
    /// <inheritdoc />
    public partial class ChangingColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_funcionarios_departments_DepartmentId",
                table: "funcionarios");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "funcionarios",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "funcionarios",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "funcionarios",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "funcionarios",
                newName: "birthday");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "funcionarios",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "funcionarios",
                newName: "department_id");

            migrationBuilder.RenameIndex(
                name: "IX_funcionarios_Cpf",
                table: "funcionarios",
                newName: "IX_funcionarios_cpf");

            migrationBuilder.RenameIndex(
                name: "IX_funcionarios_DepartmentId",
                table: "funcionarios",
                newName: "IX_funcionarios_department_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "departments",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "departments",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_departments_Name",
                table: "departments",
                newName: "IX_departments_name");

            migrationBuilder.AddForeignKey(
                name: "FK_funcionarios_departments_department_id",
                table: "funcionarios",
                column: "department_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_funcionarios_departments_department_id",
                table: "funcionarios");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "funcionarios",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "funcionarios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "funcionarios",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "birthday",
                table: "funcionarios",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "funcionarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "funcionarios",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_funcionarios_cpf",
                table: "funcionarios",
                newName: "IX_funcionarios_Cpf");

            migrationBuilder.RenameIndex(
                name: "IX_funcionarios_department_id",
                table: "funcionarios",
                newName: "IX_funcionarios_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "departments",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_departments_name",
                table: "departments",
                newName: "IX_departments_Name");

            migrationBuilder.AddForeignKey(
                name: "FK_funcionarios_departments_DepartmentId",
                table: "funcionarios",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
