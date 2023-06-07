using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ea5b9f51-1870-490f-a3d8-4dadfb42343d", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68d026ff-64cc-4f75-9dfc-ef2977bc03af", 0, "63b6c70f-ae51-4346-856e-799add100f51", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEN2NcmQT7MBKb+vfsHG69N/pVYgo1bMADrOaWopWorAXG0n6zCMlxX38fCGj1J2oMQ==", null, false, "a8075873-5674-4c39-bed0-680d68283cc0", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea5b9f51-1870-490f-a3d8-4dadfb42343d", "68d026ff-64cc-4f75-9dfc-ef2977bc03af" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea5b9f51-1870-490f-a3d8-4dadfb42343d", "68d026ff-64cc-4f75-9dfc-ef2977bc03af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea5b9f51-1870-490f-a3d8-4dadfb42343d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68d026ff-64cc-4f75-9dfc-ef2977bc03af");

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
    }
}
