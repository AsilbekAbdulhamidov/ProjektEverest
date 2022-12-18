using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.Migrations
{
    public partial class dotcom2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviewers_Interviewees_IntervieweeId",
                table: "Interviewers");

            migrationBuilder.RenameColumn(
                name: "IntervieweeId",
                table: "Interviewers",
                newName: "intervieweeId");

            migrationBuilder.RenameIndex(
                name: "IX_Interviewers_IntervieweeId",
                table: "Interviewers",
                newName: "IX_Interviewers_intervieweeId");

            migrationBuilder.AlterColumn<string>(
                name: "Projects",
                table: "Interviewers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Interviewers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Interviewers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "intervieweeId",
                table: "Interviewers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Interviewers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "Interviewers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Dagree",
                table: "Interviewers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviewers_Interviewees_intervieweeId",
                table: "Interviewers",
                column: "intervieweeId",
                principalTable: "Interviewees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviewers_Interviewees_intervieweeId",
                table: "Interviewers");

            migrationBuilder.RenameColumn(
                name: "intervieweeId",
                table: "Interviewers",
                newName: "IntervieweeId");

            migrationBuilder.RenameIndex(
                name: "IX_Interviewers_intervieweeId",
                table: "Interviewers",
                newName: "IX_Interviewers_IntervieweeId");

            migrationBuilder.AlterColumn<int>(
                name: "IntervieweeId",
                table: "Interviewers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Projects",
                table: "Interviewers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Interviewers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Interviewers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Interviewers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Experience",
                table: "Interviewers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dagree",
                table: "Interviewers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviewers_Interviewees_IntervieweeId",
                table: "Interviewers",
                column: "IntervieweeId",
                principalTable: "Interviewees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
