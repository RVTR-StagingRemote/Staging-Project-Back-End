using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class updateusermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Owners_UserId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_ClientUsers_UserID",
                table: "ClientUsers");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_UserId",
                table: "Applicants");

            migrationBuilder.AddColumn<int>(
                name: "ApplicantId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientUserId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ApplicantId",
                table: "Users",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClientUserId",
                table: "Users",
                column: "ClientUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OwnerId",
                table: "Users",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_UserId",
                table: "Owners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientUsers_UserID",
                table: "ClientUsers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_UserId",
                table: "Applicants",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Applicants_ApplicantId",
                table: "Users",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "ApplicantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ClientUsers_ClientUserId",
                table: "Users",
                column: "ClientUserId",
                principalTable: "ClientUsers",
                principalColumn: "ClientUserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Owners_OwnerId",
                table: "Users",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Applicants_ApplicantId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ClientUsers_ClientUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Owners_OwnerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ApplicantId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClientUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OwnerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Owners_UserId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_ClientUsers_UserID",
                table: "ClientUsers");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_UserId",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClientUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_UserId",
                table: "Owners",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientUsers_UserID",
                table: "ClientUsers",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_UserId",
                table: "Applicants",
                column: "UserId",
                unique: true);
        }
    }
}
