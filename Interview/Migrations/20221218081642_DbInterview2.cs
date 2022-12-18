using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.Migrations
{
    public partial class DbInterview2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviewees_Interviewers_InterviewerId",
                table: "Interviewees");

            migrationBuilder.DropIndex(
                name: "IX_Interviewees_InterviewerId",
                table: "Interviewees");

            migrationBuilder.DropColumn(
                name: "InterviewerId",
                table: "Interviewees");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Interviewees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Interviewees");

            migrationBuilder.AddColumn<int>(
                name: "IntervieweeId",
                table: "Interviewers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Interviewers_IntervieweeId",
                table: "Interviewers",
                column: "IntervieweeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviewers_Interviewees_IntervieweeId",
                table: "Interviewers",
                column: "IntervieweeId",
                principalTable: "Interviewees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviewers_Interviewees_IntervieweeId",
                table: "Interviewers");

            migrationBuilder.DropIndex(
                name: "IX_Interviewers_IntervieweeId",
                table: "Interviewers");

            migrationBuilder.DropColumn(
                name: "IntervieweeId",
                table: "Interviewers");

            migrationBuilder.AddColumn<int>(
                name: "InterviewerId",
                table: "Interviewees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Interviewees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Interviewees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Interviewees_InterviewerId",
                table: "Interviewees",
                column: "InterviewerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviewees_Interviewers_InterviewerId",
                table: "Interviewees",
                column: "InterviewerId",
                principalTable: "Interviewers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
