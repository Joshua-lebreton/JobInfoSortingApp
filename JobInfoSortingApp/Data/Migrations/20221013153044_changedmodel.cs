using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobInfoSortingApp.Data.Migrations
{
    public partial class changedmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Profiles_ProfileId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ProfileId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "SkillsId",
                table: "Profiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_SkillsId",
                table: "Profiles",
                column: "SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Skills_SkillsId",
                table: "Profiles",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "SkillsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Skills_SkillsId",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_SkillsId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ProfileId",
                table: "Skills",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Profiles_ProfileId",
                table: "Skills",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "ProfileId");
        }
    }
}
