using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class datatypechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9b29d97-d0e0-4d57-b0c1-45c74c1598b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "139f927c-a1d1-4aea-8c39-1ca3f431b71a", "AQAAAAIAAYagAAAAEO04ylRK9Tcly8OwI25121m7XiUvcTo/MsVDT3WoJTQeNwZJzhI9UEWZUar4a7RB8A==", "38aa0b09-6361-463e-a7e4-a1b5547b6194" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNo",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9b29d97-d0e0-4d57-b0c1-45c74c1598b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aab4d41c-9161-4ac5-b1a9-b430d5fd7a77", "AQAAAAIAAYagAAAAEL9ddwdGHhisy9gJVlHkqAYgIPzqUN8UxspoyxTUBsF1qiB6XTfU/T2495VycEGekg==", "abf7ce5e-59cf-4f92-8402-b53c8a62a4da" });
        }
    }
}
