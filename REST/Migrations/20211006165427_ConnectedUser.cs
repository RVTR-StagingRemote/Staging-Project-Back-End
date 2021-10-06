using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class ConnectedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_ClientsID",
                table: "Users",
                column: "ClientsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Clients_ClientsID",
                table: "Users",
                column: "ClientsID",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clients_ClientsID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClientsID",
                table: "Users");
        }
    }
}
