using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.DTOs;


namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IPerguntaRepository
    {

        Task<Pergunta> AdicionarPergunta(Pergunta pergunta);

        Task<Pergunta> GetPerguntaById(int id);
        Task<Pergunta> DeletarPerguntaById(int id);
        Task<Pergunta> EditarPerguntaById(Pergunta pergunta, int id);
        Task<IList<Pergunta>> GetAllPerguntasByQuizId(int id);



    }






}

