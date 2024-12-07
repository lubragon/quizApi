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
    }
}