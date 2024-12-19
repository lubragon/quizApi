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

    public class RespostaJogoUsuarioService: IRespostaJogoUsuarioService
    {

        private readonly IRespostaJogoUsuarioRepository _respostaJogoUsuarioRepository;
        private readonly IRespostaRepository _respostaRepository;
        private readonly IJogoUsuarioRepository _jogoUsuarioRepository;



        public RespostaJogoUsuarioService(
            IRespostaJogoUsuarioRepository respostaJogoUsuarioRepository,
            IRespostaRepository respostaRepository,
            IJogoUsuarioRepository jogoUsuarioRepository
        )
            // Aqui deve ser o repositorio
        {
            _respostaJogoUsuarioRepository = respostaJogoUsuarioRepository;
            _respostaRepository = respostaRepository;
            _jogoUsuarioRepository = jogoUsuarioRepository;

        }

        public async Task<RespostaJogoUsuario> CriarRespostaJogoUsuario(RespostaJogoUsuario respostaJogoUsuario)
        {
             return await _respostaJogoUsuarioRepository.CriarRespostaJogoUsuario(respostaJogoUsuario);
        }

        public async Task<GetRespostasDto> GetRespostaJogoUsuarioByJogoUsuarioId(int jogoUsuarioId)
        {
            return await _respostaJogoUsuarioRepository.GetRespostaJogoUsuarioByJogoUsuarioId(jogoUsuarioId);
        }

    }
}