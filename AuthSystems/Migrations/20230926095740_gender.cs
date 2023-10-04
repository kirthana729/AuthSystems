using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthSystems.Migrations
{
    /// <inheritdoc />
    public partial class gender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "SelectedIdentificationType",
                table: "AspNetUsers",
                newName: "Gender");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AspNetUsers",
                newName: "SelectedIdentificationType");

            migrationBuilder.AddColumn<string>(
                name: "IdentificationNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
