using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codefirst.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Duratuin = table.Column<int>(type: "int", nullable: true),
                    TopId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_courses_topics_TopId",
                        column: x => x.TopId,
                        principalTable: "topics",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptManager = table.Column<int>(type: "int", nullable: true),
                    ManagerHiredate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InstructorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsDegree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DeptId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructor_Department_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Department",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StFname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StLname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StAge = table.Column<int>(type: "int", nullable: true),
                    DeptId = table.Column<int>(type: "int", nullable: true),
                    StSuper = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Department_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Department",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Student_Student_StSuper",
                        column: x => x.StSuper,
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InsCourse",
                columns: table => new
                {
                    InsId = table.Column<int>(type: "int", nullable: false),
                    CrsId = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsCourse", x => x.InsId);
                    table.ForeignKey(
                        name: "FK_InsCourse_Instructor_InsId",
                        column: x => x.InsId,
                        principalTable: "Instructor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsCourse_courses_CrsId",
                        column: x => x.CrsId,
                        principalTable: "courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudCourse",
                columns: table => new
                {
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    StId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudCourse", x => x.CrsID);
                    table.ForeignKey(
                        name: "FK_StudCourse_Student_StId",
                        column: x => x.StId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudCourse_courses_CrsID",
                        column: x => x.CrsID,
                        principalTable: "courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_TopId",
                table: "courses",
                column: "TopId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_InstructorID",
                table: "Department",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_InsCourse_CrsId",
                table: "InsCourse",
                column: "CrsId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DeptId",
                table: "Instructor",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_StId",
                table: "StudCourse",
                column: "StId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DeptId",
                table: "Student",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StSuper",
                table: "Student",
                column: "StSuper");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InstructorID",
                table: "Department",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InstructorID",
                table: "Department");

            migrationBuilder.DropTable(
                name: "InsCourse");

            migrationBuilder.DropTable(
                name: "StudCourse");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "topics");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
