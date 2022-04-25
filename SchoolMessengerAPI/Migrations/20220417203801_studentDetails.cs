using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolMessengerAPI.Migrations
{
    /// <inheritdoc />
    public partial class studentDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Details");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Students",
                newName: "StudentName");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[] { 1, "Salon 01", 1 });
        }
    }
}
