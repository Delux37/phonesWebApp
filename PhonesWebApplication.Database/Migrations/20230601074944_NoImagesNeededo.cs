using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class NoImagesNeededo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Phones",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Phones",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

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
    }
}
