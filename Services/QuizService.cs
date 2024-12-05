using QuizApi.Services.Interfaces;

namespace QuizApi.Services
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