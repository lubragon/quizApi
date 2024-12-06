using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;


namespace Elevate.QuizApi.Dominio.Interfaces
{

    public interface IQuizRepository
    {
        Task<Quiz> AdicionarQuiz(Quiz quiz);
        Task<Quiz> DeletarQuizById (int id);
        Task<Quiz> AtualizarQuiz(Quiz obj);
        Task<Quiz> GetQuizById(int id);
    }
}