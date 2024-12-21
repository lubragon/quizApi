using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using System.ComponentModel.DataAnnotations;
using Elevate.QuizApi.Data.Repositories;
using Elevate.QuizApi.Dominio.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Services
{

    public class JogoUsuarioService: IJogoUsuarioService
    {

        private readonly IJogoUsuarioRepository _jogoUsuarioRepository;
        private readonly IRespostaRepository _respostaRepository;


        public JogoUsuarioService(
            IJogoUsuarioRepository jogoUsuarioRepository,
            IRespostaRepository respostaRepository
        )
            // Aqui deve ser o repositorio
        {
            _jogoUsuarioRepository = jogoUsuarioRepository;
            _respostaRepository = respostaRepository;

        }

        public async Task<JogoUsuario> CriarJogoUsuario(JogoUsuario jogoUsuario)
        {
            return await _jogoUsuarioRepository.CriarJogoUsuario(jogoUsuario);
        }

        public async Task<GetRespostasDto> GetJogoUsuarioByJogoIdAndUsuarioId([FromQuery] int jogoId, int usuarioId)
        {
            return await _jogoUsuarioRepository.GetJogoUsuarioByJogoIdAndUsuarioId(jogoId, usuarioId);
        }


		}
	}