using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Vacation_Manager.Migrations.Project_Vacation_Manager
{
    public partial class teams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teams",
                table: "Project");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Team",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_ProjectId",
                table: "Team",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Project_ProjectId",
                table: "Team",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Project_ProjectId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_ProjectId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Team");

            migrationBuilder.AddColumn<string>(
                name: "Teams",
                table: "Project",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
