using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_Charts_CartId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Charts_AspNetUsers_UserId",
                table: "Charts");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Charts_CartId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_CartId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Accessories_CartId",
                table: "Accessories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Charts",
                table: "Charts");

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
                table: "Accessories");

            migrationBuilder.DropColumn(
                name: "AccessoryId",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "AccessoryIsBought",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "PhoneIsBought",
                table: "Charts");

            migrationBuilder.RenameTable(
                name: "Charts",
                newName: "Carts");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Phones",
                newName: "Price");

            migrationBuilder.RenameIndex(
                name: "IX_Charts_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CartPhone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartPhone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartPhone_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartPhone_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CartPhone_CartId",
                table: "CartPhone",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartPhone_PhoneId",
                table: "CartPhone",
                column: "PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "CartPhone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

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

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Charts");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Phones",
                newName: "Amount");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Charts",
                newName: "IX_Charts_UserId");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Phones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Accessories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessoryId",
                table: "Charts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AccessoryIsBought",
                table: "Charts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "Charts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneIsBought",
                table: "Charts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Charts",
                table: "Charts",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_Charts_CartId",
                table: "Accessories",
                column: "CartId",
                principalTable: "Charts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Charts_AspNetUsers_UserId",
                table: "Charts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Charts_CartId",
                table: "Phones",
                column: "CartId",
                principalTable: "Charts",
                principalColumn: "Id");
        }
    }
}
