using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class xy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedAnswerID",
                table: "StudentAnswerResponse");

            migrationBuilder.CreateTable(
                name: "SelectedAnswer",
                columns: table => new
                {
                    SelectedAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentAnswerResponseId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedAnswer", x => x.SelectedAnswerId);
                    table.ForeignKey(
                        name: "FK_SelectedAnswer_StudentAnswerResponse_StudentAnswerResponseId",
                        column: x => x.StudentAnswerResponseId,
                        principalTable: "StudentAnswerResponse",
                        principalColumn: "StudentAnswerResponseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedAnswer_StudentAnswerResponseId",
                table: "SelectedAnswer",
                column: "StudentAnswerResponseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedAnswer");

            migrationBuilder.AddColumn<int>(
                name: "SelectedAnswerID",
                table: "StudentAnswerResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
