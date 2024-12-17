using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseProject.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenCourseAndClassroomFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomId",
                table: "Courses",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
