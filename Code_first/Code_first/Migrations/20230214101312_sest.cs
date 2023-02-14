using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codefirst.Migrations
{
    /// <inheritdoc />
    public partial class sest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InstructorID",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_InstructorID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_InstructorID",
                table: "Department",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InstructorID",
                table: "Department",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID");
        }
    }
}
