using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IJogoRepository
    {
        Task<Jogo> CriarJogo(Jogo jogo , int idQuiz);
        Task<Jogo> IniciarJogoById(int jogoId);
        Task<Jogo> DeletarJogoById(int id);
        Task<Jogo> GetJogoById(int id);
        Task<List<Jogo>> GetTodosJogos();

    }

}