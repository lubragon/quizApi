using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
using Elevate.QuizApi.Services.Interfaces;

namespace Elevate.QuizApi.Services
{

    public class QuizService: IQuizService
    {
        private readonly IQuizRepository _quizRepository;


        public QuizService(
            IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public Task<Quiz> AdicionarQuiz(Quiz quiz)
        {
            return _quizRepository.AdicionarQuiz(quiz);
        }

        public Task<Quiz> AtualizarQuiz(Quiz obj)
        {
            throw new NotImplementedException();
        }

        public Task<Quiz> DeletarQuizById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Quiz> GetQuizById(int id)
        {
            throw new NotImplementedException();
        }



        /*
        Iniciar quiz
        Remover
        
        */


    }







}