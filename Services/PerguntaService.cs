using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;

namespace Elevate.QuizApi.Services
{

    public class PerguntaService: IPerguntaService
    {
        private readonly IPerguntaRepository _perguntaRepository;
        private readonly IRespostaService _respostaService;


        public PerguntaService(
            IPerguntaRepository perguntaRepository)
            // Aqui deve ser o repositorio
        {
            _perguntaRepository = perguntaRepository;
        }

        public Task<Pergunta> AdicionarPergunta(Pergunta pergunta)
        {
            throw new NotImplementedException();
        }

        // Usar service daqui par a fazer VALIDACOES

        /*
        - Adicionar pergunta ao banco de dados
        - GetPergunta
        - Remover pergunta
        - ValidarPergunta?
        
        
        */


    }







}