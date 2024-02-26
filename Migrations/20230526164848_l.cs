using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class l : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswerCount",
                table: "TestTaker");

            migrationBuilder.DropColumn(
                name: "FinalScore",
                table: "TestTaker");

            migrationBuilder.DropColumn(
                name: "SubmitedAnswerCount",
                table: "TestTaker");

            migrationBuilder.RenameColumn(
                name: "TimeTakenSeconds",
                table: "TestTaker",
                newName: "TotalTakeTime");

            migrationBuilder.CreateTable(
                name: "TestTakerResult",
                columns: table => new
                {
                    TestTakerResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestTakerId = table.Column<int>(type: "int", nullable: false),
                    FinalScore = table.Column<float>(type: "real", nullable: false),
                    TimeTakenSeconds = table.Column<int>(type: "int", nullable: false),
                    SubmitedAnswerCount = table.Column<int>(type: "int", nullable: false),
                    CorrectAnswerCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTakerResult", x => x.TestTakerResultId);
                    table.ForeignKey(
                        name: "FK_TestTakerResult_TestTaker_TestTakerId",
                        column: x => x.TestTakerId,
                        principalTable: "TestTaker",
                        principalColumn: "TestTakerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestTakerResult_TestTakerId",
                table: "TestTakerResult",
                column: "TestTakerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestTakerResult");

            migrationBuilder.RenameColumn(
                name: "TotalTakeTime",
                table: "TestTaker",
                newName: "TimeTakenSeconds");

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswerCount",
                table: "TestTaker",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "FinalScore",
                table: "TestTaker",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "SubmitedAnswerCount",
                table: "TestTaker",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
