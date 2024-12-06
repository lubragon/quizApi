using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IPerguntaService
    {
        Task<Pergunta> AdicionarPergunta(Pergunta pergunta);

        Task<Pergunta> GetPerguntaById(int id);
        Task<Pergunta> DeletarPerguntaById(int id);
    }







}