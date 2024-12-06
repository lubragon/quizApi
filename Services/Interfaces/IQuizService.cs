using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IQuizService
    {
        Task<Quiz> AdicionarQuiz(Quiz quiz);
        Task<Quiz> DeletarQuizById (int id);
        Task<Quiz> AtualizarQuiz(Quiz obj);
        Task<Quiz> GetQuizById(int id);


        
    }







}