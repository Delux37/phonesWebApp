using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class WasNotLat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Phones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Accessories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Charts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneId = table.Column<int>(type: "int", nullable: false),
                    PhoneIsBought = table.Column<bool>(type: "bit", nullable: false),
                    AccessoryId = table.Column<int>(type: "int", nullable: false),
                    AccessoryIsBought = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11202a1b-7966-4758-a2e5-a52a5f944d37", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CartId", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c31533f-6f5c-48ab-bb49-f9bfddc8775d", 0, 0, "b2c89558-24f6-4220-ad73-9bd35e800be7", "ApplicationUsers", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.com", "AQAAAAIAAYagAAAAECCEBnIZNOj3ZN5q17T7S6QMckeyDWd78d8cz+BXhBGwl61o+u1zzVcooSOUgVfpvw==", null, false, "263861d7-5b9f-4587-ab6f-b852c44a3b31", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11202a1b-7966-4758-a2e5-a52a5f944d37", "9c31533f-6f5c-48ab-bb49-f9bfddc8775d" });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CartId",
                table: "Phones",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_CartId",
                table: "Accessories",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Charts_UserId",
                table: "Charts",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_Charts_CartId",
                table: "Accessories",
                column: "CartId",
                principalTable: "Charts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Charts_CartId",
                table: "Phones",
                column: "CartId",
                principalTable: "Charts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_Charts_CartId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Charts_CartId",
                table: "Phones");

            migrationBuilder.DropTable(
                name: "Charts");

            migrationBuilder.DropIndex(
                name: "IX_Phones_CartId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Accessories_CartId",
                table: "Accessories");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11202a1b-7966-4758-a2e5-a52a5f944d37", "9c31533f-6f5c-48ab-bb49-f9bfddc8775d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11202a1b-7966-4758-a2e5-a52a5f944d37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c31533f-6f5c-48ab-bb49-f9bfddc8775d");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Accessories");

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
    }
}
