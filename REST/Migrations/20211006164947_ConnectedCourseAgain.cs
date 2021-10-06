using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class ConnectedCourseAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "OrderDetails",
                newName: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "OrderDetails",
                newName: "CoursesId");
        }
    }
}
