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
        public Task<Pergunta> EditarPerguntaById(Pergunta pergunta, int id)
        {
            return _perguntaRepository.EditarPerguntaById(pergunta, id);
        }


        public Task<Pergunta> DeletarPerguntaById(int id)
        {
            return _perguntaRepository.DeletarPerguntaById(id);
        }

        public Task<Pergunta> GetPerguntaById(int id)
        {
            return _perguntaRepository.GetPerguntaById(id);
        }
        public Task<IList<Pergunta>> GetAllPerguntasByQuizId(int id)
        {
            return _perguntaRepository.GetAllPerguntasByQuizId(id);
        }
    }







}