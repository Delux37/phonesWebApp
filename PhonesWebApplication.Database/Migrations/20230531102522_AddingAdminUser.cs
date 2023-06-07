using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddingAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
