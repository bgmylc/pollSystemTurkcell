using Microsoft.EntityFrameworkCore.Migrations;

namespace pollSystemTurkcell.Migrations
{
    public partial class ReplyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollUser_Polls_PollID",
                table: "PollUser");

            migrationBuilder.DropForeignKey(
                name: "FK_PollUser_Users_UserID",
                table: "PollUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PollUser",
                table: "PollUser");

            migrationBuilder.RenameTable(
                name: "PollUser",
                newName: "PollUsers");

            migrationBuilder.RenameIndex(
                name: "IX_PollUser_UserID",
                table: "PollUsers",
                newName: "IX_PollUsers_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PollUsers",
                table: "PollUsers",
                columns: new[] { "PollID", "UserID" });

            migrationBuilder.AddForeignKey(
                name: "FK_PollUsers_Polls_PollID",
                table: "PollUsers",
                column: "PollID",
                principalTable: "Polls",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PollUsers_Users_UserID",
                table: "PollUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollUsers_Polls_PollID",
                table: "PollUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PollUsers_Users_UserID",
                table: "PollUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PollUsers",
                table: "PollUsers");

            migrationBuilder.RenameTable(
                name: "PollUsers",
                newName: "PollUser");

            migrationBuilder.RenameIndex(
                name: "IX_PollUsers_UserID",
                table: "PollUser",
                newName: "IX_PollUser_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PollUser",
                table: "PollUser",
                columns: new[] { "PollID", "UserID" });

            migrationBuilder.AddForeignKey(
                name: "FK_PollUser_Polls_PollID",
                table: "PollUser",
                column: "PollID",
                principalTable: "Polls",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PollUser_Users_UserID",
                table: "PollUser",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
