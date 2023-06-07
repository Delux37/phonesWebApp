using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class changeInPhonesDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82da8483-a54b-460a-8567-95eabff7dc0f", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6775ff82-2cee-48e4-bc5b-6e9aa28dcdb2", 0, "12380b51-c628-47df-9820-1ea46fc2bc8d", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEBlJzz/PQsa9iSWNJ9gJMLeJDFHdN6W3WRxweZFe5njAUxzimaHl98nI7+lEghk1fA==", null, false, "c728e692-87a3-4505-af68-1355fdb6b9d9", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "82da8483-a54b-460a-8567-95eabff7dc0f", "6775ff82-2cee-48e4-bc5b-6e9aa28dcdb2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "82da8483-a54b-460a-8567-95eabff7dc0f", "6775ff82-2cee-48e4-bc5b-6e9aa28dcdb2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82da8483-a54b-460a-8567-95eabff7dc0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6775ff82-2cee-48e4-bc5b-6e9aa28dcdb2");

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
    }
}
