using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using System.ComponentModel.DataAnnotations;
using Elevate.QuizApi.Data.Repositories;
using Elevate.QuizApi.Dominio.DTOs;

namespace Elevate.QuizApi.Services
{

    public class UsuarioService: IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;


        public UsuarioService(
            IUsuarioRepository usuarioRepository
        )
            // Aqui deve ser o repositorio
        {
            _usuarioRepository = usuarioRepository;

        }

        public Task<Usuario> CriarUsuario(Usuario usuario)
        {
            return _usuarioRepository.CriarUsuario(usuario);
        }

        public Task<Usuario> GetUsuarioById(int idUsuario)
        {
            return _usuarioRepository.GetUsuarioById(idUsuario);
        }

         public Task<UsuarioDto>  GetUsuarioByEmail(string emailUsuario)
        {
            return _usuarioRepository.GetUsuarioByEmail(emailUsuario);
        }

        public Task<Usuario> GetByLogin(string login)
        {
            return _usuarioRepository.GetByLogin(login);
        }

        public Task<UsuarioDto> Insert(UsuarioDto usuario)
        {
            return _usuarioRepository.Insert(usuario);
        }
        public Task<Usuario> CriarUsuarioAdministrador(Usuario usuario)
        {
            return _usuarioRepository.CriarUsuarioAdministrador(usuario);
        }
    }
}