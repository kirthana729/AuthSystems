using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthSystems.Migrations
{
    /// <inheritdoc />
    public partial class authorise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentificationNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SelectedIdentificationType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SelectedIdentificationType",
                table: "AspNetUsers");
        }
    }
}
