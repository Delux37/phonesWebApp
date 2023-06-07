using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class smt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Phones");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2aac71f5-d797-4ff4-9bc8-d05c02eefec0", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3aea647f-f7d2-4983-90fe-82a346a36138", 0, "8089c0dd-2e1f-4124-b92b-361e7196bccf", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEKue8sQ5MlXg4uG4sMzEI5aMDzNq8Yg1gI0poSgrw+7I8bQTyr2stMjrOXLtLx1PwA==", null, false, "458d47c2-ede2-4818-9fd3-d152fe8da1cb", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2aac71f5-d797-4ff4-9bc8-d05c02eefec0", "3aea647f-f7d2-4983-90fe-82a346a36138" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2aac71f5-d797-4ff4-9bc8-d05c02eefec0", "3aea647f-f7d2-4983-90fe-82a346a36138" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2aac71f5-d797-4ff4-9bc8-d05c02eefec0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aea647f-f7d2-4983-90fe-82a346a36138");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Phones",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

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
    }
}
