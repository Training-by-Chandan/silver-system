using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApps.Db.EF.CodeFirst.Migrations
{
    public partial class classIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Students");
        }
    }
}
