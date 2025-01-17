

using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Enums;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class UsuarioDto : ModelBaseDto
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }
        public TipoUsuarioEnum Tipo{ get; set; }


        public UsuarioDto(string nome, string email, TipoUsuarioEnum tipo, string login)
        {
            Nome = nome;
            Email = email;
            Tipo = tipo;
            Login = login;

        }

        public UsuarioDto()
        {
            
        }
        public UsuarioDto(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Email = usuario.Email;
            Tipo = usuario.Tipo;
            Login = usuario.Login;

        } 
    }

}