using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveHashAddTipoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashSenha",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Usuario",
                type: "int",
                maxLength: 1,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "HashSenha",
                table: "Usuario",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
