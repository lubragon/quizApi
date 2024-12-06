using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quiz_Evento_IdEvento",
                table: "Quiz");

            migrationBuilder.DropIndex(
                name: "IX_Quiz_IdEvento",
                table: "Quiz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Quiz_IdEvento",
                table: "Quiz",
                column: "IdEvento");

            migrationBuilder.AddForeignKey(
                name: "FK_Quiz_Evento_IdEvento",
                table: "Quiz",
                column: "IdEvento",
                principalTable: "Evento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
