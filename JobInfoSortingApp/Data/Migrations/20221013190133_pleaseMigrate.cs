using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobInfoSortingApp.Data.Migrations
{
    public partial class pleaseMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Skills_SkillsId",
                table: "Profiles");

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Skills_SkillsId",
                table: "Profiles",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "SkillsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Skills_SkillsId",
                table: "Profiles");

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "Profiles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Skills_SkillsId",
                table: "Profiles",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "SkillsId");
        }
    }
}
