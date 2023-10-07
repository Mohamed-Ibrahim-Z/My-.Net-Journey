using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Management.Data.Migrations
{
    public partial class AddedNewColumnsToUser_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Users_UserId",
                table: "Task");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Task",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Users_UserId",
                table: "Task",
                column: "UserId",
                principalSchema: "Task",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Users_UserId",
                table: "Task");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Task",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Users_UserId",
                table: "Task",
                column: "UserId",
                principalSchema: "Task",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
