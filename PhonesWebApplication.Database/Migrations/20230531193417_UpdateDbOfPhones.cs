using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbOfPhones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc7751c5-9bcd-4599-b78d-5fd33e5f60ac", "d31618ed-80d6-4b33-8c0e-386bf325d5de" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc7751c5-9bcd-4599-b78d-5fd33e5f60ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d31618ed-80d6-4b33-8c0e-386bf325d5de");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Phones",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "PhoneInfo",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2e2341c-21fb-4cf1-a2a4-c4d9ddd2f2cc", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b493cf5e-dc95-4c77-a79f-2171b48cf693", 0, "ca242760-1238-4c0d-9805-fc82c9df2793", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEGElFkUZW+BF135TiB9V6SLH85cNLPER0djFqN3q4hN73Ay+vtUHl3NZ4KKzPF/LRg==", null, false, "49d2151b-ec21-4d5f-868a-1e3e19703cbb", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f2e2341c-21fb-4cf1-a2a4-c4d9ddd2f2cc", "b493cf5e-dc95-4c77-a79f-2171b48cf693" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2e2341c-21fb-4cf1-a2a4-c4d9ddd2f2cc", "b493cf5e-dc95-4c77-a79f-2171b48cf693" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2e2341c-21fb-4cf1-a2a4-c4d9ddd2f2cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b493cf5e-dc95-4c77-a79f-2171b48cf693");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "PhoneInfo",
                table: "Phones");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc7751c5-9bcd-4599-b78d-5fd33e5f60ac", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d31618ed-80d6-4b33-8c0e-386bf325d5de", 0, "9d1ea37b-91cd-4ced-b5a0-eece08cc51df", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEHeOqRzlKHUMt36Pnez1PL9fYCqe5fMo5zlsSfP3gsCIE3uVeCGafi2Glt9Q756fKw==", null, false, "a6c5f9b1-77a5-4ef9-af94-f9681cf7ddae", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dc7751c5-9bcd-4599-b78d-5fd33e5f60ac", "d31618ed-80d6-4b33-8c0e-386bf325d5de" });
        }
    }
}
