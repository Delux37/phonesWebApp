using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class updatePhonesDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83ea92f6-2828-4a62-98b0-c0153ea6d88c", "3e78f4f3-3f66-458a-97f0-ef1a6d154f1a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ea92f6-2828-4a62-98b0-c0153ea6d88c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e78f4f3-3f66-458a-97f0-ef1a6d154f1a");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Phones");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Phones",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d05d2c8-82d8-4c60-9d34-3d89f2fb1212", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "faba4446-99a0-41ae-bcf0-aaddc34750df", 0, "ec0058c0-c5fa-49d6-8740-8b1b633af899", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEOoxscehE1gl4VxyYIynpWNXJBI/h9EV/e4MykgXfYncNLycXJjNQV0ZRazgt9GJ6w==", null, false, "029e9843-ce0b-4b0b-8e76-0872f84fcf0f", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5d05d2c8-82d8-4c60-9d34-3d89f2fb1212", "faba4446-99a0-41ae-bcf0-aaddc34750df" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d05d2c8-82d8-4c60-9d34-3d89f2fb1212", "faba4446-99a0-41ae-bcf0-aaddc34750df" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d05d2c8-82d8-4c60-9d34-3d89f2fb1212");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faba4446-99a0-41ae-bcf0-aaddc34750df");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Phones");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Phones",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83ea92f6-2828-4a62-98b0-c0153ea6d88c", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3e78f4f3-3f66-458a-97f0-ef1a6d154f1a", 0, "494a8450-b187-4fdc-93a8-dc03bfb5e5f0", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEJHLob5rEgNQg60Osm5wHQ/rC7FEsS4bj5dCUA0i0p9w4/rLSrLzVCmtljVcERPhEg==", null, false, "a44a7eaf-ba8d-4be4-8f58-0559d6d56538", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "83ea92f6-2828-4a62-98b0-c0153ea6d88c", "3e78f4f3-3f66-458a-97f0-ef1a6d154f1a" });
        }
    }
}
