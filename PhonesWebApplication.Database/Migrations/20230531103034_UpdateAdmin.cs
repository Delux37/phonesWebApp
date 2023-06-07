using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af020c63-5744-4371-b016-c8cc1cca7a09", "c6145bdd-9471-4ded-bca1-ecbcdd8bfb28" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af020c63-5744-4371-b016-c8cc1cca7a09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6145bdd-9471-4ded-bca1-ecbcdd8bfb28");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af020c63-5744-4371-b016-c8cc1cca7a09", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6145bdd-9471-4ded-bca1-ecbcdd8bfb28", 0, "7be867e2-bbb7-48e3-b2f6-8bec1fc75be2", "ApplicationUsers", "admin@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEOf/GsCVvn3TsPRHhbt9T4Kcb0LqH3qi73s8bxnV+DTlSo6FJdLkPrUTcBMI+tTd4w==", null, false, "9670b618-518d-491d-a0e2-787c487d3f4b", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af020c63-5744-4371-b016-c8cc1cca7a09", "c6145bdd-9471-4ded-bca1-ecbcdd8bfb28" });
        }
    }
}
