using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class ques : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_QuestionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Tests_TestId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Tests_TestId1",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTakers_Tests_TestId",
                table: "TestTakers");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTakers_Users_StudentUserId",
                table: "TestTakers");

            migrationBuilder.DropTable(
                name: "StudentAnswerResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestTakers",
                table: "TestTakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.RenameTable(
                name: "TestTakers",
                newName: "TestTaker");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameIndex(
                name: "IX_TestTakers_TestId",
                table: "TestTaker",
                newName: "IX_TestTaker_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_TestTakers_StudentUserId",
                table: "TestTaker",
                newName: "IX_TestTaker_StudentUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_TestId1",
                table: "Question",
                newName: "IX_Question_TestId1");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_TestId",
                table: "Question",
                newName: "IX_Question_TestId");

            migrationBuilder.AddColumn<bool>(
                name: "AllowOnlyOneTry",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StudentCanSeeAnswersAfterDone",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StudentCanSeeFinalScore",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SwapQuestionAndAnswersOrder",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestTaker",
                table: "TestTaker",
                column: "TestTakerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Tests_TestId",
                table: "Question",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Tests_TestId1",
                table: "Question",
                column: "TestId1",
                principalTable: "Tests",
                principalColumn: "TestId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Tests_TestId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Tests_TestId1",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTaker_Tests_TestId",
                table: "TestTaker");

            migrationBuilder.DropForeignKey(
                name: "FK_TestTaker_Users_StudentUserId",
                table: "TestTaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestTaker",
                table: "TestTaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "AllowOnlyOneTry",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "StudentCanSeeAnswersAfterDone",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "StudentCanSeeFinalScore",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "SwapQuestionAndAnswersOrder",
                table: "Tests");

            migrationBuilder.RenameTable(
                name: "TestTaker",
                newName: "TestTakers");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameIndex(
                name: "IX_TestTaker_TestId",
                table: "TestTakers",
                newName: "IX_TestTakers_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_TestTaker_StudentUserId",
                table: "TestTakers",
                newName: "IX_TestTakers_StudentUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_TestId1",
                table: "Questions",
                newName: "IX_Questions_TestId1");

            migrationBuilder.RenameIndex(
                name: "IX_Question_TestId",
                table: "Questions",
                newName: "IX_Questions_TestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestTakers",
                table: "TestTakers",
                column: "TestTakerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "QuestionId");

            migrationBuilder.CreateTable(
                name: "StudentAnswerResponses",
                columns: table => new
                {
                    StudentAnswerResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SelectedOption = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAnswerResponses", x => x.StudentAnswerResponseId);
                    table.ForeignKey(
                        name: "FK_StudentAnswerResponses_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAnswerResponses_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAnswerResponses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswerResponses_QuestionId",
                table: "StudentAnswerResponses",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswerResponses_TestId",
                table: "StudentAnswerResponses",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswerResponses_UserId",
                table: "StudentAnswerResponses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Tests_TestId",
                table: "Questions",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Tests_TestId1",
                table: "Questions",
                column: "TestId1",
                principalTable: "Tests",
                principalColumn: "TestId");

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
    }
}
