using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class JogoUsuarioFkIdJogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tempo",
                table: "Pergunta");

            migrationBuilder.AddColumn<int>(
                name: "idJogo",
                table: "JogoUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idJogo",
                table: "JogoUsuario");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Tempo",
                table: "Pergunta",
                type: "time(6)",
                nullable: true);
        }
    }
}
