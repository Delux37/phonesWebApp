using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class migraiton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf6449f6-7078-4679-80e8-d240ca391241", "9e1e19fd-0519-47a5-a1d2-334a1703b941" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf6449f6-7078-4679-80e8-d240ca391241");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e1e19fd-0519-47a5-a1d2-334a1703b941");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b3f300c-acb0-41aa-8434-c99c736d277b", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CartId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f645749e-93b4-4707-83b7-9c9cd199d063", 0, 0, "e2caab69-e72a-4088-a341-68705e31ce6f", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEM/iN9WTyevL/MoLgB+uN2ImHEVsRadhcu6Lzj7o6Xhp6PMc+y2QEfleXITaXMLekg==", null, false, "eb676f50-31e3-41da-ae65-cc7f8d709293", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b3f300c-acb0-41aa-8434-c99c736d277b", "f645749e-93b4-4707-83b7-9c9cd199d063" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b3f300c-acb0-41aa-8434-c99c736d277b", "f645749e-93b4-4707-83b7-9c9cd199d063" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b3f300c-acb0-41aa-8434-c99c736d277b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f645749e-93b4-4707-83b7-9c9cd199d063");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf6449f6-7078-4679-80e8-d240ca391241", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CartId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9e1e19fd-0519-47a5-a1d2-334a1703b941", 0, 0, "4c14760c-cb47-4c21-adea-6f30100ce763", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEIlYOK1hDZLyeSJlPho6tf0zlYK5ZtVzlzrvP69TANmRWl4riBEHS9NqR/unb+gmsw==", null, false, "0d630844-838c-4b9c-a0a9-9589f5ae584e", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cf6449f6-7078-4679-80e8-d240ca391241", "9e1e19fd-0519-47a5-a1d2-334a1703b941" });
        }
    }
}
