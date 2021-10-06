using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class ConnectedUserAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clients_ClientsID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClientsID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ClientsID",
                table: "Users",
                newName: "ClientID");

            migrationBuilder.AddColumn<int>(
                name: "ClientsClientId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClientsClientId",
                table: "Users",
                column: "ClientsClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Clients_ClientsClientId",
                table: "Users",
                column: "ClientsClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clients_ClientsClientId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClientsClientId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClientsClientId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Users",
                newName: "ClientsID");

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
    }
}
