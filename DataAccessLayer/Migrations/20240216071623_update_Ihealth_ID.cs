using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class update_Ihealth_ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Sliders",
                newName: "SliderID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ContactInformations",
                newName: "ContactInformationID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Communacations",
                newName: "CommunacationID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Campanys",
                newName: "CampanyID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Blogs",
                newName: "BlogID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Abouts",
                newName: "AboutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SliderID",
                table: "Sliders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ContactInformationID",
                table: "ContactInformations",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CommunacationID",
                table: "Communacations",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CampanyID",
                table: "Campanys",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Blogs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "ID");
        }
    }
}
