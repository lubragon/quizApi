using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;

namespace Elevate.QuizApi.Services
{

    public class PerguntaService: IPerguntaService
    {
        private readonly IPerguntaService _perguntaService;
        private readonly IRespostaService _respostaService;


        public PerguntaService(
            IPerguntaService perguntaService)
        {
            _perguntaService = perguntaService;
        }

        public async Task<Pergunta> AdicionarPergunta(Pergunta obj)
        {
            try
            {
                var pergunta = new Pergunta(obj.Texto)
                {
                    Texto = obj.Texto,
                    Respostas = obj.Respostas,
                    Quiz = obj.Quiz
                };

                // Texto da Pergunta
                // Tempo em segundos pra pergunta
                // Como adicionar as respostas? 
                // Definir qual resposta é a certa

                // Usar Pergunta ou PerguntaDto?
                return await _perguntaService.AdicionarPergunta(pergunta);
        

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao adicionar pergunta", ex);

            }
        }

        /*
        - Adicionar pergunta ao banco de dados
        - GetPergunta
        - Remover pergunta
        - ValidarPergunta?
        
        
        */


    }







}