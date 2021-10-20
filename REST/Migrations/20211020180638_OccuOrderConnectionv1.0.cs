using Microsoft.EntityFrameworkCore.Migrations;

namespace REST.Migrations
{
    public partial class OccuOrderConnectionv10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OccupationId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OccupationId",
                table: "Orders");
        }
    }
}
