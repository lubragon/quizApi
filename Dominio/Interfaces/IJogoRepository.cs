using Elevate.QuizApi.Dominio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IJogoRepository
    {
        //Task<Jogo> CriarJogo(Jogo jogo);
        //Task<Jogo> EditarJogo(Jogo jogo);
        Task<Jogo> DeletarJogoById(int id);
        Task<Jogo> GetJogoById(int id);
        Task<List<Jogo>> GetTodosJogos();

    }

}