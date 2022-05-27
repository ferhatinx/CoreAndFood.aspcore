using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAndFood.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodLongDescription",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "FoodShortDescription",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "ThumbnailImageUrl",
                table: "Foods",
                newName: "FoodDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodDescription",
                table: "Foods",
                newName: "ThumbnailImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "FoodLongDescription",
                table: "Foods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FoodShortDescription",
                table: "Foods",
                nullable: true);
        }
    }
}
