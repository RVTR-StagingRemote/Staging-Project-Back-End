using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class InitialCreatene006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ClientsClientId",
                table: "Orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderName",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderId",
                table: "OrderDetails",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientsClientId",
                table: "Orders",
                column: "ClientsClientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrdersOrderId",
                table: "OrderDetails",
                column: "OrdersOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrdersOrderId",
                table: "OrderDetails",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientsClientId",
                table: "Orders",
                column: "ClientsClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrdersOrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientsClientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientsClientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrdersOrderId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ClientsClientId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrdersOrderId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
