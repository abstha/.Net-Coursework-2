using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW.Migrations
{
    /// <inheritdoc />
    public partial class updateduserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "UsersModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UsersModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "UsersModel");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UsersModel");
        }
    }
}
