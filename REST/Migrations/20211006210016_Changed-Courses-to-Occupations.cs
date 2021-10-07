using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace REST.Migrations
{
    public partial class ChangedCoursestoOccupations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Courses_CoursesCourseId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "CoursesTopicsJoins");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.RenameColumn(
                name: "CoursesCourseId",
                table: "OrderDetails",
                newName: "OccupationsOccupationId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "OrderDetails",
                newName: "OccupationId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_CoursesCourseId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OccupationsOccupationId");

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    OccupationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OccupationName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.OccupationId);
                });

            migrationBuilder.CreateTable(
                name: "OccupationsTopicsJoins",
                columns: table => new
                {
                    JoinId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OccupationsId = table.Column<int>(type: "integer", nullable: false),
                    TopicsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationsTopicsJoins", x => x.JoinId);
                    table.ForeignKey(
                        name: "FK_OccupationsTopicsJoins_Occupations_OccupationsId",
                        column: x => x.OccupationsId,
                        principalTable: "Occupations",
                        principalColumn: "OccupationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccupationsTopicsJoins_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OccupationsTopicsJoins_OccupationsId",
                table: "OccupationsTopicsJoins",
                column: "OccupationsId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationsTopicsJoins_TopicsId",
                table: "OccupationsTopicsJoins",
                column: "TopicsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Occupations_OccupationsOccupationId",
                table: "OrderDetails",
                column: "OccupationsOccupationId",
                principalTable: "Occupations",
                principalColumn: "OccupationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Occupations_OccupationsOccupationId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OccupationsTopicsJoins");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.RenameColumn(
                name: "OccupationsOccupationId",
                table: "OrderDetails",
                newName: "CoursesCourseId");

            migrationBuilder.RenameColumn(
                name: "OccupationId",
                table: "OrderDetails",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OccupationsOccupationId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_CoursesCourseId");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "CoursesTopicsJoins",
                columns: table => new
                {
                    JoinId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoursesId = table.Column<int>(type: "integer", nullable: false),
                    TopicsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesTopicsJoins", x => x.JoinId);
                    table.ForeignKey(
                        name: "FK_CoursesTopicsJoins_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesTopicsJoins_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "TopicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursesTopicsJoins_CoursesId",
                table: "CoursesTopicsJoins",
                column: "CoursesId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesTopicsJoins_TopicsId",
                table: "CoursesTopicsJoins",
                column: "TopicsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Courses_CoursesCourseId",
                table: "OrderDetails",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
