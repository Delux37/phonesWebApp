using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangeServiceTableToAccessories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneServices_Services_AccessoryId",
                table: "PhoneServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Accessories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accessories",
                table: "Accessories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneServices_Accessories_AccessoryId",
                table: "PhoneServices",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneServices_Accessories_AccessoryId",
                table: "PhoneServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accessories",
                table: "Accessories");

            migrationBuilder.RenameTable(
                name: "Accessories",
                newName: "Services");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneServices_Services_AccessoryId",
                table: "PhoneServices",
                column: "AccessoryId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
