using QuizApi.Services.Interfaces;

namespace QuizApi.Services
{

    public class PerguntaService: IPerguntaService
    {
        private readonly IPerguntaService _perguntaService;


        public PerguntaService(
            IPerguntaService perguntaService)
        {
            _perguntaService = perguntaService;
        }

        /*
        - Adicionar pergunta ao banco de dados
        - GetPergunta
        - Remover pergunta
        - ValidarPergunta?
        
        
        */


    }







}