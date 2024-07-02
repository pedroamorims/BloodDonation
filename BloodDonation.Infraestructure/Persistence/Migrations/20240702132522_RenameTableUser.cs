using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDonation.Infraestructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityClaim_User_UserId",
                table: "IdentityClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityRole_User_UserId",
                table: "IdentityRole");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserLogin_User_UserId",
                table: "IdentityUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole_User_UserId",
                table: "IdentityUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserToken_User_UserId",
                table: "IdentityUserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_NormalizedUserName",
                table: "Users",
                newName: "IX_Users_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_User_NormalizedEmail",
                table: "Users",
                newName: "IX_Users_NormalizedEmail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityClaim_Users_UserId",
                table: "IdentityClaim",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRole_Users_UserId",
                table: "IdentityRole",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin_Users_UserId",
                table: "IdentityUserLogin",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole_Users_UserId",
                table: "IdentityUserRole",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserToken_Users_UserId",
                table: "IdentityUserToken",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Users_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityClaim_Users_UserId",
                table: "IdentityClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityRole_Users_UserId",
                table: "IdentityRole");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserLogin_Users_UserId",
                table: "IdentityUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole_Users_UserId",
                table: "IdentityUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserToken_Users_UserId",
                table: "IdentityUserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_NormalizedUserName",
                table: "User",
                newName: "IX_User_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_NormalizedEmail",
                table: "User",
                newName: "IX_User_NormalizedEmail");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityClaim_User_UserId",
                table: "IdentityClaim",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRole_User_UserId",
                table: "IdentityRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin_User_UserId",
                table: "IdentityUserLogin",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole_User_UserId",
                table: "IdentityUserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserToken_User_UserId",
                table: "IdentityUserToken",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
