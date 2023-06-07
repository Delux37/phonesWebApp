using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhonesWebApplication.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangeServiceToAccessory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneServices_Services_ServiceId",
                table: "PhoneServices");

            migrationBuilder.RenameColumn(
                name: "ServiceName",
                table: "Services",
                newName: "AccessoryName");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "PhoneServices",
                newName: "AccessoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneServices_ServiceId",
                table: "PhoneServices",
                newName: "IX_PhoneServices_AccessoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneServices_Services_AccessoryId",
                table: "PhoneServices",
                column: "AccessoryId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneServices_Services_AccessoryId",
                table: "PhoneServices");

            migrationBuilder.RenameColumn(
                name: "AccessoryName",
                table: "Services",
                newName: "ServiceName");

            migrationBuilder.RenameColumn(
                name: "AccessoryId",
                table: "PhoneServices",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneServices_AccessoryId",
                table: "PhoneServices",
                newName: "IX_PhoneServices_ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneServices_Services_ServiceId",
                table: "PhoneServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
