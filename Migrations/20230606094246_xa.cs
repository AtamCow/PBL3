using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class xa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswerResponse_TestTakerResult_TestTakerResultId",
                table: "StudentAnswerResponse");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswerResponse_TestTakerResult_TestTakerResultId",
                table: "StudentAnswerResponse",
                column: "TestTakerResultId",
                principalTable: "TestTakerResult",
                principalColumn: "TestTakerResultId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswerResponse_TestTakerResult_TestTakerResultId",
                table: "StudentAnswerResponse");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswerResponse_TestTakerResult_TestTakerResultId",
                table: "StudentAnswerResponse",
                column: "TestTakerResultId",
                principalTable: "TestTakerResult",
                principalColumn: "TestTakerResultId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
