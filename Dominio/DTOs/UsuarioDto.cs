

using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class UsuarioDto : ModelBaseDto
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string HashSenha { get; set; }

        public UsuarioDto(string nome, string email, string hashSenha)
        {
            Nome = nome;
            Email = email;
            HashSenha = hashSenha;

        }

        public UsuarioDto(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Email = usuario.Email;
            HashSenha = usuario.HashSenha;
        } 
    }

}