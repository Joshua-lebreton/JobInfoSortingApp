using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobInfoSortingApp.Data.Migrations
{
    public partial class RemovedResume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resume",
                table: "Profiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resume",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
