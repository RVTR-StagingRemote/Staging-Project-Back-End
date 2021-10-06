using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace REST.Migrations
{
    public partial class AddedConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeSkills");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "OrderDetails",
                newName: "CoursesId");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "CoursesTopicsJoins",
                newName: "TopicsId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CoursesTopicsJoins",
                newName: "CoursesId");

            migrationBuilder.AddColumn<int>(
                name: "ClientsID",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientsID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "OrderDetails",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "TopicsId",
                table: "CoursesTopicsJoins",
                newName: "TopicId");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CoursesTopicsJoins",
                newName: "CourseId");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DOB = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Degree = table.Column<string>(type: "text", nullable: true),
                    EmployeeType = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    StateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoursesTopicsJoinJoinId = table.Column<int>(type: "integer", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: true),
                    EmplyeeId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TopicsJoinId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSkills_CoursesTopicsJoins_CoursesTopicsJoinJoinId",
                        column: x => x.CoursesTopicsJoinJoinId,
                        principalTable: "CoursesTopicsJoins",
                        principalColumn: "JoinId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeSkills_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StateId",
                table: "Employees",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkills_CoursesTopicsJoinJoinId",
                table: "EmployeeSkills",
                column: "CoursesTopicsJoinJoinId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkills_EmployeeId",
                table: "EmployeeSkills",
                column: "EmployeeId");
        }
    }
}
