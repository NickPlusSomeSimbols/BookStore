using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Stores_StoreId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_StoreId",
                table: "Storages");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Stores",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_StorageId",
                table: "Stores",
                column: "StorageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Storages_StorageId",
                table: "Stores",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Storages_StorageId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_StorageId",
                table: "Stores");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Stores",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Storages_StoreId",
                table: "Storages",
                column: "StoreId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Stores_StoreId",
                table: "Storages",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
