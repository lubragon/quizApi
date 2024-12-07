using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IQuizService
    {
        Task<Quiz> AdicionarQuiz(Quiz quiz);
        Task<Quiz> DeletarQuiz (Quiz quiz);
        Task<Quiz> DeletarQuizById (int id);
        Task<Quiz> EditarQuizById(Quiz quiz, int id);
        Task<Quiz> GetQuizById(int id);
        Task<IList<Quiz>> GetAllQuizzes();



        
    }







}