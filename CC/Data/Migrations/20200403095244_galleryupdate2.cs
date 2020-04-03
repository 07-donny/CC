using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CC.Data.Migrations
{
    public partial class galleryupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Img",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Images");
        }
    }
}
