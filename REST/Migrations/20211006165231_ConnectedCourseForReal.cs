using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class ConnectedCourseForReal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                table: "OrderDetails",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CoursesCourseId",
                table: "OrderDetails",
                column: "CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Courses_CoursesCourseId",
                table: "OrderDetails",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Courses_CoursesCourseId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_CoursesCourseId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                table: "OrderDetails");
        }
    }
}
