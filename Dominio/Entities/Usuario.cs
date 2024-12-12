
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

        //public string? HashSenha { get; set; }
        // TODO SENHA E HASH LDAP

        public Usuario(string nome, string email, TipoUsuarioEnum tipo)
        {
            Nome = nome;
            Email = email;
            Tipo = tipo;
            //HashSenha = hashSenha;
        }

        public Usuario(UsuarioDto usuarioDto)
        {
            Id = usuarioDto.Id;
            Nome = usuarioDto.Nome;
            Email = usuarioDto.Email;
            Tipo = usuarioDto.Tipo;
            //HashSenha = usuarioDto.HashSenha;
        }

    }



}