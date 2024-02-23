using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class updateSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SliderImage",
                table: "Sliders",
                newName: "SliderImageTwo");

            migrationBuilder.AddColumn<string>(
                name: "SliderImageOne",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderImageThree",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderImageOne",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SliderImageThree",
                table: "Sliders");

            migrationBuilder.RenameColumn(
                name: "SliderImageTwo",
                table: "Sliders",
                newName: "SliderImage");
        }
    }
}
