using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS1.Migrations
{
    public partial class mapping1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studs",
                table: "Studs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoursesLists",
                table: "CoursesLists");

            migrationBuilder.AlterColumn<int>(
                name: "stud_ID",
                table: "Studs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "inst_ID",
                table: "CoursesLists",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Top_Id",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studs",
                table: "Studs",
                columns: new[] { "Course_ID", "stud_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoursesLists",
                table: "CoursesLists",
                columns: new[] { "Course_ID", "inst_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Studs_stud_ID",
                table: "Studs",
                column: "stud_ID");

            migrationBuilder.CreateIndex(
                name: "IX_students_Dep_Id",
                table: "students",
                column: "Dep_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesLists_inst_ID",
                table: "CoursesLists",
                column: "inst_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses",
                column: "Top_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses",
                column: "Top_Id",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesLists_Courses_Course_ID",
                table: "CoursesLists",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesLists_Instructors_inst_ID",
                table: "CoursesLists",
                column: "inst_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_Departments_Dep_Id",
                table: "students",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Studs_Courses_Course_ID",
                table: "Studs",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Studs_students_stud_ID",
                table: "Studs",
                column: "stud_ID",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesLists_Courses_Course_ID",
                table: "CoursesLists");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesLists_Instructors_inst_ID",
                table: "CoursesLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_students_Departments_Dep_Id",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_Studs_Courses_Course_ID",
                table: "Studs");

            migrationBuilder.DropForeignKey(
                name: "FK_Studs_students_stud_ID",
                table: "Studs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studs",
                table: "Studs");

            migrationBuilder.DropIndex(
                name: "IX_Studs_stud_ID",
                table: "Studs");

            migrationBuilder.DropIndex(
                name: "IX_students_Dep_Id",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoursesLists",
                table: "CoursesLists");

            migrationBuilder.DropIndex(
                name: "IX_CoursesLists_inst_ID",
                table: "CoursesLists");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "stud_ID",
                table: "Studs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "inst_ID",
                table: "CoursesLists",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Top_Id",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studs",
                table: "Studs",
                column: "stud_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoursesLists",
                table: "CoursesLists",
                column: "inst_ID");
        }
    }
}
