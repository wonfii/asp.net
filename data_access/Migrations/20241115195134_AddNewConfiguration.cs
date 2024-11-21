using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class AddNewConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectsId",
                table: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.RenameColumn(
                name: "SubjectsId",
                table: "StudentSubject",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "StudentSubject",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubject_SubjectsId",
                table: "StudentSubject",
                newName: "IX_StudentSubject_SubjectId");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "FieldOfStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "IX_Students_FieldOfStudyId");

            migrationBuilder.CreateTable(
                name: "FieldsOfStudy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldsOfStudy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldOfStudySubject",
                columns: table => new
                {
                    FieldOfStudyId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldOfStudySubject", x => new { x.FieldOfStudyId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_FieldOfStudySubject_FieldsOfStudy_FieldOfStudyId",
                        column: x => x.FieldOfStudyId,
                        principalTable: "FieldsOfStudy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FieldOfStudySubject_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FieldsOfStudy",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Mechanical Engineering" },
                    { 3, "Electrical Engineering" },
                    { 4, "Physics" },
                    { 5, "Applied Information Technology" },
                    { 6, "Digital Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Ects", "IsOptional", "Name" },
                values: new object[,]
                {
                    { 6, 4, false, "Calculus" },
                    { 7, 5, false, "Operating Systems" },
                    { 8, 8, false, "Programming" },
                    { 9, 5, false, "Structural Analysis" },
                    { 10, 3, false, "Computer Aided Engineering" },
                    { 11, 6, false, "Energy Systems" },
                    { 12, 5, false, "Structural Analysis" },
                    { 13, 3, false, "Electrical Energy Production Transportation and Distribution" },
                    { 14, 6, false, "Trafic Infrastructure Design" },
                    { 15, 5, false, "Physics" },
                    { 16, 3, false, "Linear Algebra" },
                    { 17, 6, false, "Introduction to Biological Physics" },
                    { 18, 5, false, "Databases" },
                    { 19, 6, false, "Software Engineering" },
                    { 20, 6, false, "Interaction Design" },
                    { 21, 5, false, "Programming for Engineers" },
                    { 22, 3, false, "Artificial Intelligence for Smart Technologies" },
                    { 23, 6, false, "Introduction to IOT" }
                });

            migrationBuilder.InsertData(
                table: "FieldOfStudySubject",
                columns: new[] { "FieldOfStudyId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 18 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 16 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 5, 16 },
                    { 5, 18 },
                    { 5, 19 },
                    { 5, 20 },
                    { 6, 21 },
                    { 6, 22 },
                    { 6, 23 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FieldOfStudySubject_SubjectId",
                table: "FieldOfStudySubject",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_FieldsOfStudy_FieldOfStudyId",
                table: "Students",
                column: "FieldOfStudyId",
                principalTable: "FieldsOfStudy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Students_StudentId",
                table: "StudentSubject",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectId",
                table: "StudentSubject",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_FieldsOfStudy_FieldOfStudyId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Students_StudentId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectId",
                table: "StudentSubject");

            migrationBuilder.DropTable(
                name: "FieldOfStudySubject");

            migrationBuilder.DropTable(
                name: "FieldsOfStudy");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "StudentSubject",
                newName: "SubjectsId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "StudentSubject",
                newName: "StudentsId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                newName: "IX_StudentSubject_SubjectsId");

            migrationBuilder.RenameColumn(
                name: "FieldOfStudyId",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_FieldOfStudyId",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudyYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "StudyYear" },
                values: new object[,]
                {
                    { 1, "Computer Science", 1 },
                    { 2, "Mechanical Engineering", 2 },
                    { 3, "Electrical Engineering", 3 },
                    { 4, "Physics", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectsId",
                table: "StudentSubject",
                column: "SubjectsId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
