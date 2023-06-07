using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhoneServiceToPhoneAccessories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneServices_Accessories_AccessoryId",
                table: "PhoneServices");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneServices_Phones_PhoneId",
                table: "PhoneServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneServices",
                table: "PhoneServices");

            migrationBuilder.RenameTable(
                name: "PhoneServices",
                newName: "PhoneAccessories");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneServices_PhoneId",
                table: "PhoneAccessories",
                newName: "IX_PhoneAccessories_PhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneServices_AccessoryId",
                table: "PhoneAccessories",
                newName: "IX_PhoneAccessories_AccessoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneAccessories",
                table: "PhoneAccessories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneAccessories_Accessories_AccessoryId",
                table: "PhoneAccessories",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneAccessories_Phones_PhoneId",
                table: "PhoneAccessories",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneAccessories_Accessories_AccessoryId",
                table: "PhoneAccessories");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneAccessories_Phones_PhoneId",
                table: "PhoneAccessories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneAccessories",
                table: "PhoneAccessories");

            migrationBuilder.RenameTable(
                name: "PhoneAccessories",
                newName: "PhoneServices");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneAccessories_PhoneId",
                table: "PhoneServices",
                newName: "IX_PhoneServices_PhoneId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneAccessories_AccessoryId",
                table: "PhoneServices",
                newName: "IX_PhoneServices_AccessoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneServices",
                table: "PhoneServices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneServices_Accessories_AccessoryId",
                table: "PhoneServices",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneServices_Phones_PhoneId",
                table: "PhoneServices",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
