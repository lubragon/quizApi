using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class JogadorAvulso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JogoUsuario_Usuario_IdUsuario",
                table: "JogoUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "JogoUsuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "JogadorAvulso",
                table: "JogoUsuario",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_JogoUsuario_Usuario_IdUsuario",
                table: "JogoUsuario",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JogoUsuario_Usuario_IdUsuario",
                table: "JogoUsuario");

            migrationBuilder.DropColumn(
                name: "JogadorAvulso",
                table: "JogoUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "JogoUsuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JogoUsuario_Usuario_IdUsuario",
                table: "JogoUsuario",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
