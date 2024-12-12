
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Usuario : ModelBase
    {

        public string Nome { get; set; }

        public string Email { get; set; }

        public TipoUsuarioEnum Tipo{ get; set; }
        public string Login { get; set; }


        public Usuario(string nome, string email, TipoUsuarioEnum tipo, string login)
        {
            Nome = nome;
            Email = email;
            Tipo = tipo;
            Login = login;
        }

        public Usuario(UsuarioDto usuarioDto)
        {
            Id = usuarioDto.Id;
            Nome = usuarioDto.Nome;
            Email = usuarioDto.Email;
            Tipo = usuarioDto.Tipo;
            Login = usuarioDto.Login;
        }

    }



}