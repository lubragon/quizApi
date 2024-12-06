
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Usuario : ModelBase
    {

        public string Nome { get; set; }

        public string Email { get; set; }

        public string HashSenha { get; set; }


        public Usuario(string nome, string email, string hashSenha)
        {
            Nome = nome;
            Email = email;
            HashSenha = hashSenha;
        }

        public Usuario(UsuarioDto usuarioDto)
        {
            Id = usuarioDto.Id;
            Nome = usuarioDto.Nome;
            Email = usuarioDto.Email;
            HashSenha = usuarioDto.HashSenha;
        }

    }



}