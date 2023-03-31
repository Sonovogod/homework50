using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeWork.Migrations
{
    public partial class adddickriptionproptotheSeaFoodModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "SeaFoods",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "SeaFoods");
        }
    }
}
