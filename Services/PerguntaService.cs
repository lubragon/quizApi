using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Elevate.QuizApi.Services
{

    public class PerguntaService: IPerguntaService
    {

        private readonly IPerguntaRepository _perguntaRepository;
        private readonly IRespostaService _respostaService;


        public PerguntaService(
            IPerguntaRepository perguntaRepository,
            IRespostaService respostaService    
        )
            // Aqui deve ser o repositorio
        {
            _perguntaRepository = perguntaRepository;
            _respostaService = respostaService;

        }
    }







}