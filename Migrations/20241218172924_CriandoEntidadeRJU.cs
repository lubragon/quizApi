using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class CriandoEntidadeRJU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespostaJogoUsuario");

            migrationBuilder.AddColumn<int>(
                name: "JogoUsuarioId",
                table: "Respostas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Respostas_JogoUsuarioId",
                table: "Respostas",
                column: "JogoUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Respostas_JogoUsuario_JogoUsuarioId",
                table: "Respostas",
                column: "JogoUsuarioId",
                principalTable: "JogoUsuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Respostas_JogoUsuario_JogoUsuarioId",
                table: "Respostas");

            migrationBuilder.DropIndex(
                name: "IX_Respostas_JogoUsuarioId",
                table: "Respostas");

            migrationBuilder.DropColumn(
                name: "JogoUsuarioId",
                table: "Respostas");

            migrationBuilder.CreateTable(
                name: "RespostaJogoUsuario",
                columns: table => new
                {
                    JogoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    RespostaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespostaJogoUsuario", x => new { x.JogoUsuarioId, x.RespostaId });
                    table.ForeignKey(
                        name: "FK_RespostaJogoUsuario_JogoUsuario_JogoUsuarioId",
                        column: x => x.JogoUsuarioId,
                        principalTable: "JogoUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RespostaJogoUsuario_Respostas_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Respostas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RespostaJogoUsuario_RespostaId",
                table: "RespostaJogoUsuario",
                column: "RespostaId");
        }
    }
}
