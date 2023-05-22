using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopApi.Migrations
{
    /// <inheritdoc />
    public partial class editedfeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Feedbacks",
                newName: "feedback");

            migrationBuilder.RenameColumn(
                name: "Query",
                table: "Feedbacks",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "feedback",
                table: "Feedbacks",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Feedbacks",
                newName: "Query");
        }
    }
}
