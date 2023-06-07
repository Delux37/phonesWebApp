using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class asdasdad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a006cab2-e6bd-47df-941e-5cd4ac00a86f", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0fd2277b-c873-462d-9b47-dcc4da65366b", 0, "e0d09103-a779-4412-a7b3-112324961c54", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEHSKq2k8Ua7w8LXlB+v8z7iMlw8x1OTQNSZMx8EguAicxkHwSYZwhzf6jf0iWKa42g==", null, false, "fbe5b3d7-736b-4c36-a970-1d224f9b1d98", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a006cab2-e6bd-47df-941e-5cd4ac00a86f", "0fd2277b-c873-462d-9b47-dcc4da65366b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a006cab2-e6bd-47df-941e-5cd4ac00a86f", "0fd2277b-c873-462d-9b47-dcc4da65366b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a006cab2-e6bd-47df-941e-5cd4ac00a86f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fd2277b-c873-462d-9b47-dcc4da65366b");

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
    }
}
