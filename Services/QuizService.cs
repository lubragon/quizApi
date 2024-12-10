using Elevate.QuizApi.Dominio.DTOs;
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
        public Task<IList<QuizDto>> GetAllQuizzes()
        {
            return _quizRepository.GetAllQuizzes();
        }

        public async Task<QuizDto> GetQuizById(int id)
        {
            var quizz = await _quizRepository.GetQuizById(id);

            return new QuizDto(quizz);
        }

        public Task<Quiz> EditarQuizById(Quiz quiz, int id)
        {
            return _quizRepository.EditarQuizById(quiz, id);
        }

        public Task<Quiz> DeletarQuiz(Quiz obj)
        {
            return _quizRepository.DeletarQuiz(obj);
        }
        public Task<Quiz> DeletarQuizById(int id)
        {
            return _quizRepository.DeletarQuizById(id);
        }

        



        /*
        Iniciar quiz
        Remover
        
        */


    }







}