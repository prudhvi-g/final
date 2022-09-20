using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_E_Grocecry.Migrations
{
    public partial class initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rating",
                table: "item",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "itemPrice",
                table: "item",
                newName: "Item Price");

            migrationBuilder.RenameColumn(
                name: "itemName",
                table: "item",
                newName: "Item Name");

            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "item",
                newName: "Item Id");

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(nullable: true),
                    orderPlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.orderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "item",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Item Price",
                table: "item",
                newName: "itemPrice");

            migrationBuilder.RenameColumn(
                name: "Item Name",
                table: "item",
                newName: "itemName");

            migrationBuilder.RenameColumn(
                name: "Item Id",
                table: "item",
                newName: "itemId");
        }
    }
}
