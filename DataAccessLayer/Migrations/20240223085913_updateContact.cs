using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class updateContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CampanyID",
                table: "Campanys",
                newName: "CompanyID");

            migrationBuilder.AddColumn<string>(
                name: "lınkedinLink",
                table: "ContactInformations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lınkedinLink",
                table: "ContactInformations");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Campanys",
                newName: "CampanyID");
        }
    }
}
