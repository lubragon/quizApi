using Elevate.QuizApi.Services.Interfaces;

namespace Elevate.QuizApi.Services
{

    public class QuizService: IQuizService
    {
        private readonly IQuizService _quizService;


        public QuizService(
            IQuizService quizService)
        {
            _quizService = quizService;
        }


        
        /*
        Iniciar quiz
        Remover
        
        */


    }







}