using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class r : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "TestTaker",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TestTaker_ClassId",
                table: "TestTaker",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestTaker_Classes_ClassId",
                table: "TestTaker",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestTaker_Classes_ClassId",
                table: "TestTaker");

            migrationBuilder.DropIndex(
                name: "IX_TestTaker_ClassId",
                table: "TestTaker");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "TestTaker");
        }
    }
}
