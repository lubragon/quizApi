using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IJogoUsuarioService
    {
			Task<JogoUsuarioDto> CriarJogoUsuario(JogoUsuarioDto jogo, int idQuiz, int idJogo);

    }



}