using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyCartPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc8d3b90-67ab-4ee1-b2e2-adc7bf350470", "7a3f3293-5015-4c39-bc9d-83a50ba9fdc8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc8d3b90-67ab-4ee1-b2e2-adc7bf350470");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a3f3293-5015-4c39-bc9d-83a50ba9fdc8");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cc8d3b90-67ab-4ee1-b2e2-adc7bf350470", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CartId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7a3f3293-5015-4c39-bc9d-83a50ba9fdc8", 0, 0, "c0d6a826-76a1-46a9-bbe8-a8f7575ee159", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEA7K9eg54DcI9YTZaSj2piUQHbZS4JgdoEoAMUcAmfYQDxIDXt93ev2TG/B5ggMcmw==", null, false, "7e90c5e8-a629-47ed-9faf-3650f0190b04", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc8d3b90-67ab-4ee1-b2e2-adc7bf350470", "7a3f3293-5015-4c39-bc9d-83a50ba9fdc8" });
        }
    }
}
