using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class hopeItsLast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Phones",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "AccessoryInfo",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Accessories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0d5fda0-2204-4a53-9a26-306ce9f4fd91", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1c60c21-46d1-43a3-95d8-c4b2587d5cc9", 0, "c4a07fc4-1615-4eef-90db-18297c6bdf45", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAEKhp041GLk5kMk47FdppiI1F2+X1YgLsWamJKKENYhisgNs9V00LAw65V3B7j9qxPQ==", null, false, "d4c19c06-47a2-4c93-8c56-fc60ecf62c97", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e0d5fda0-2204-4a53-9a26-306ce9f4fd91", "a1c60c21-46d1-43a3-95d8-c4b2587d5cc9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0d5fda0-2204-4a53-9a26-306ce9f4fd91", "a1c60c21-46d1-43a3-95d8-c4b2587d5cc9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0d5fda0-2204-4a53-9a26-306ce9f4fd91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1c60c21-46d1-43a3-95d8-c4b2587d5cc9");

            migrationBuilder.DropColumn(
                name: "AccessoryInfo",
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Accessories");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Phones",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
    }
}
