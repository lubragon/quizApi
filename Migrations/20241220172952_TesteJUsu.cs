using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class TesteJUsu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "JogoUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JogoUsuario_JogoId",
                table: "JogoUsuario",
                column: "JogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_JogoUsuario_Jogos_JogoId",
                table: "JogoUsuario",
                column: "JogoId",
                principalTable: "Jogos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JogoUsuario_Jogos_JogoId",
                table: "JogoUsuario");

            migrationBuilder.DropIndex(
                name: "IX_JogoUsuario_JogoId",
                table: "JogoUsuario");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "JogoUsuario");
        }
    }
}
