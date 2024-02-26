using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class xx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMoreThanOneCorrectAnswer",
                table: "Question",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "StudentAnswerResponse",
                columns: table => new
                {
                    StudentAnswerResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestTakerResultId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    SelectedAnswerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAnswerResponse", x => x.StudentAnswerResponseId);
                    table.ForeignKey(
                        name: "FK_StudentAnswerResponse_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAnswerResponse_TestTakerResult_TestTakerResultId",
                        column: x => x.TestTakerResultId,
                        principalTable: "TestTakerResult",
                        principalColumn: "TestTakerResultId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswerResponse_QuestionId",
                table: "StudentAnswerResponse",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswerResponse_TestTakerResultId",
                table: "StudentAnswerResponse",
                column: "TestTakerResultId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAnswerResponse");

            migrationBuilder.DropColumn(
                name: "IsMoreThanOneCorrectAnswer",
                table: "Question");
        }
    }
}
