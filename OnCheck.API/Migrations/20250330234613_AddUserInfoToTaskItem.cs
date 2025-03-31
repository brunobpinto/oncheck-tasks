using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnCheck.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserInfoToTaskItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserFirstName",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserLastName",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserFirstName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UserLastName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Tasks");
        }
    }
}
