using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme2.Migrations
{
    /// <inheritdoc />
    public partial class migoneto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserCategory_UserDetailsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserDetailsId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserDetailsId",
                table: "Users",
                newName: "UserCategoryId");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "UserCategory",
                newName: "Address");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserCategory_UserId",
                table: "UserCategory",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategory_Users_UserId",
                table: "UserCategory",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategory_Users_UserId",
                table: "UserCategory");

            migrationBuilder.DropIndex(
                name: "IX_UserCategory_UserId",
                table: "UserCategory");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserCategory");

            migrationBuilder.RenameColumn(
                name: "UserCategoryId",
                table: "Users",
                newName: "UserDetailsId");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "UserCategory",
                newName: "Adress");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserDetailsId",
                table: "Users",
                column: "UserDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserCategory_UserDetailsId",
                table: "Users",
                column: "UserDetailsId",
                principalTable: "UserCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
