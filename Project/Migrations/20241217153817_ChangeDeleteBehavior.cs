using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseProject.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ClassRoomId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "ClassRoomId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "ClassRooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassRoomId",
                table: "Courses",
                column: "ClassRoomId",
                unique: true,
                filter: "[ClassRoomId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ClassRoomId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "ClassRoomId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "ClassRooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassRoomId",
                table: "Courses",
                column: "ClassRoomId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "Id");
        }
    }
}
