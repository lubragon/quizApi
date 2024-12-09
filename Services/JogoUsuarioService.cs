using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using System.ComponentModel.DataAnnotations;
using Elevate.QuizApi.Data.Repositories;
using Elevate.QuizApi.Dominio.DTOs;

namespace Elevate.QuizApi.Services
{

    public class JogoUsuarioService: IJogoUsuarioService
    {

        private readonly IJogoUsuarioRepository _jogoUsuarioRepository;


        public JogoUsuarioService(
            IJogoUsuarioRepository jogoUsuarioRepository
        )
            // Aqui deve ser o repositorio
        {
            _jogoUsuarioRepository = jogoUsuarioRepository;

        }

        public Task<JogoUsuarioDto> CriarJogoUsuario(JogoUsuarioDto jogoUsuarioDto, int idQuiz, int idJogo)
        {
             return _jogoUsuarioRepository.CriarJogoUsuario(jogoUsuarioDto, idQuiz, idJogo);
        }
		}
	}