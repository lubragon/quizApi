using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class CriandoEntidadeRJU_Correto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RespostaJogoUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdJogoUsuario = table.Column<int>(type: "int", nullable: false),
                    IdResposta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespostaJogoUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RespostaJogoUsuario_JogoUsuario_IdJogoUsuario",
                        column: x => x.IdJogoUsuario,
                        principalTable: "JogoUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RespostaJogoUsuario_Respostas_IdResposta",
                        column: x => x.IdResposta,
                        principalTable: "Respostas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RespostaJogoUsuario_IdJogoUsuario",
                table: "RespostaJogoUsuario",
                column: "IdJogoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_RespostaJogoUsuario_IdResposta",
                table: "RespostaJogoUsuario",
                column: "IdResposta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespostaJogoUsuario");
        }
    }
}
