using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using System.ComponentModel.DataAnnotations;
using Elevate.QuizApi.Data.Repositories;
using Elevate.QuizApi.Dominio.DTOs;

namespace Elevate.QuizApi.Services
{

    public class JogoService: IJogoService
    {

        private readonly IJogoRepository _jogoRepository;


        public JogoService(
            IJogoRepository jogoRepository
        )
            // Aqui deve ser o repositorio
        {
            _jogoRepository = jogoRepository;

        }

        
        public Task<Jogo> CriarJogo(Jogo jogo, int idQuiz)
        {
            return _jogoRepository.CriarJogo(jogo, idQuiz);
        }

        public Task<Jogo> IniciarJogoById(int jogoId)
        {
            return _jogoRepository.IniciarJogoById(jogoId);
        }


    }







}