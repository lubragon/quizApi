using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IJogoService
    {
			Task<Jogo> CriarJogo(Jogo jogo, int idQuiz);

    }



}