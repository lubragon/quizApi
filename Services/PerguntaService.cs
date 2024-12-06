using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using System.ComponentModel.DataAnnotations;
using Elevate.QuizApi.Data.Repositories;
using Elevate.QuizApi.Dominio.DTOs;

namespace Elevate.QuizApi.Services
{

    public class PerguntaService: IPerguntaService
    {

        private readonly IPerguntaRepository _perguntaRepository;


        public PerguntaService(
            IPerguntaRepository perguntaRepository
        )
            // Aqui deve ser o repositorio
        {
            _perguntaRepository = perguntaRepository;

        }

        public Task<Pergunta> AdicionarPergunta(Pergunta pergunta)
        {
            return _perguntaRepository.AdicionarPergunta(pergunta);
        }

        public Task<Pergunta> DeletarPerguntaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pergunta> GetPerguntaById(int id)
        {
            throw new NotImplementedException();
        }
    }







}