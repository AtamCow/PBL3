using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class t : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestTaker_Classes_ClassId",
                table: "TestTaker");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTaker_Tests_TestId",
                table: "TestTaker");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTaker_Users_StudentUserId",
                table: "TestTaker");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTakerResult_TestTaker_TestTakerId",
                table: "TestTakerResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestTaker",
                table: "TestTaker");

            migrationBuilder.RenameTable(
                name: "TestTaker",
                newName: "TestTakers");

            migrationBuilder.RenameIndex(
                name: "IX_TestTaker_TestId",
                table: "TestTakers",
                newName: "IX_TestTakers_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_TestTaker_StudentUserId",
                table: "TestTakers",
                newName: "IX_TestTakers_StudentUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TestTaker_ClassId",
                table: "TestTakers",
                newName: "IX_TestTakers_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestTakers",
                table: "TestTakers",
                column: "TestTakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestTakerResult_TestTakers_TestTakerId",
                table: "TestTakerResult",
                column: "TestTakerId",
                principalTable: "TestTakers",
                principalColumn: "TestTakerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestTakers_Classes_ClassId",
                table: "TestTakers",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestTakers_Tests_TestId",
                table: "TestTakers",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestTakers_Users_StudentUserId",
                table: "TestTakers",
                column: "StudentUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestTakerResult_TestTakers_TestTakerId",
                table: "TestTakerResult");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTakers_Classes_ClassId",
                table: "TestTakers");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTakers_Tests_TestId",
                table: "TestTakers");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTakers_Users_StudentUserId",
                table: "TestTakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestTakers",
                table: "TestTakers");

            migrationBuilder.RenameTable(
                name: "TestTakers",
                newName: "TestTaker");

            migrationBuilder.RenameIndex(
                name: "IX_TestTakers_TestId",
                table: "TestTaker",
                newName: "IX_TestTaker_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_TestTakers_StudentUserId",
                table: "TestTaker",
                newName: "IX_TestTaker_StudentUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TestTakers_ClassId",
                table: "TestTaker",
                newName: "IX_TestTaker_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestTaker",
                table: "TestTaker",
                column: "TestTakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestTaker_Classes_ClassId",
                table: "TestTaker",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestTaker_Tests_TestId",
                table: "TestTaker",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestTaker_Users_StudentUserId",
                table: "TestTaker",
                column: "StudentUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestTakerResult_TestTaker_TestTakerId",
                table: "TestTakerResult",
                column: "TestTakerId",
                principalTable: "TestTaker",
                principalColumn: "TestTakerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
