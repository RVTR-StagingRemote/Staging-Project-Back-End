using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class fixedJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CoursesTopicsJoins_CoursesId",
                table: "CoursesTopicsJoins",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesTopicsJoins_TopicsId",
                table: "CoursesTopicsJoins",
                column: "TopicsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesTopicsJoins_Courses_CoursesId",
                table: "CoursesTopicsJoins",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesTopicsJoins_Topics_TopicsId",
                table: "CoursesTopicsJoins",
                column: "TopicsId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoursesTopicsJoins_Courses_CoursesId",
                table: "CoursesTopicsJoins");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesTopicsJoins_Topics_TopicsId",
                table: "CoursesTopicsJoins");

            migrationBuilder.DropIndex(
                name: "IX_CoursesTopicsJoins_CoursesId",
                table: "CoursesTopicsJoins");

            migrationBuilder.DropIndex(
                name: "IX_CoursesTopicsJoins_TopicsId",
                table: "CoursesTopicsJoins");
        }
    }
}
