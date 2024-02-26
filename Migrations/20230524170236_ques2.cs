using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class ques2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "TestTaker");

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_CreatorId",
                table: "Tests",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Users_CreatorId",
                table: "Tests",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Users_CreatorId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_CreatorId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Tests");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "TestTaker",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
