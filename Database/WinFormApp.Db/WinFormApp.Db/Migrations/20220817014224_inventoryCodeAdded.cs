using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormApp.Db.Migrations
{
    public partial class inventoryCodeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Inventory",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Inventory");
        }
    }
}
