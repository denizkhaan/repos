using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme2.Migrations
{
    /// <inheritdoc />
    public partial class onetoone2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCategory_Users_Id",
                table: "UserCategory");

            migrationBuilder.AddColumn<int>(
                name: "UserDetailsId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserCategory_UserDetailsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserDetailsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserDetailsId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategory_Users_Id",
                table: "UserCategory",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
