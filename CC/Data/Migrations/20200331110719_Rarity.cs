using Microsoft.EntityFrameworkCore.Migrations;

namespace CC.Data.Migrations
{
    public partial class Rarity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rarity",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rarity",
                table: "Product");
        }
    }
}
