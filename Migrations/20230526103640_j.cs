using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class j : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Tests_TestId1",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_TestId1",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "TestId1",
                table: "Question");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestId1",
                table: "Question",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_TestId1",
                table: "Question",
                column: "TestId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Tests_TestId1",
                table: "Question",
                column: "TestId1",
                principalTable: "Tests",
                principalColumn: "TestId");
        }
    }
}
