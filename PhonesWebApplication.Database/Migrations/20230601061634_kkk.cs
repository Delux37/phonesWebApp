using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class kkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ae6d3bdc-ac5a-4ba4-b513-06651d099b1a", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "88977cec-7251-410f-8936-c76bc4f65c68", 0, "646f2da7-cdd7-4c09-a596-d04347479209", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEM0DXAyDo2q9vHzMWhxmbElTpDRJHLI0sUDdA4dVAeiDk4ehAuOpeNeoRJR7uHJUFQ==", null, false, "f6fe1ee4-306f-42ec-b983-9b4f81d7f131", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ae6d3bdc-ac5a-4ba4-b513-06651d099b1a", "88977cec-7251-410f-8936-c76bc4f65c68" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae6d3bdc-ac5a-4ba4-b513-06651d099b1a", "88977cec-7251-410f-8936-c76bc4f65c68" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae6d3bdc-ac5a-4ba4-b513-06651d099b1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88977cec-7251-410f-8936-c76bc4f65c68");

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
    }
}
