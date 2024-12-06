using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;


namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IPerguntaRepository
    {

        Task<Pergunta> AdicionarPergunta(Pergunta pergunta);

        Task<Pergunta> GetPerguntaById(int id);
        Task<Pergunta> DeletarPerguntaById(int id);



    }






}

