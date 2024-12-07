

using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class UsuarioDto : ModelBaseDto
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public UsuarioDto(string nome, string email)
        {
            Nome = nome;
            Email = email;

        }

        public UsuarioDto()
        {
            
        }
        public UsuarioDto(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Email = usuario.Email;

        } 
    }

}