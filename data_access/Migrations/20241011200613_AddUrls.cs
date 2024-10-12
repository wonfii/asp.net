using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class AddUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudyField",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudentImage",
                value: "https://i.pinimg.com/564x/d1/2d/ec/d12dece72502dd732b11ec5a66fb9076.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "StudentImage",
                value: "https://i.pinimg.com/enabled_lo/564x/8b/9a/02/8b9a02ac3ea4d3bdb3e1403c34a6c232.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "StudentImage",
                value: "https://i.pinimg.com/564x/db/c5/e6/dbc5e69ece5632c0885e497d1882d40b.jpg");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "StudentImage",
                value: "https://i.pinimg.com/736x/74/94/71/749471a2654703b02997f7357ef57a37.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudyField",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "StudentImage", "StudyField" },
                values: new object[] { "", "Computer Science" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "StudyField",
                value: "Computer Science");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StudentImage", "StudyField" },
                values: new object[] { "", "Mechanical Engineering" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "StudentImage", "StudyField" },
                values: new object[] { "", "Mechanical Engineering" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "StudyField",
                value: "Electrical Engineering");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "StudyField",
                value: "Physics");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "StudentImage", "StudyField" },
                values: new object[] { "", "Physics" });
        }
    }
}
