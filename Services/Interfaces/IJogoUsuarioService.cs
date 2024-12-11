using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IJogoUsuarioService
    {
			Task<JogoUsuario> CriarJogoUsuario(JogoUsuario jogoUsuario, int idResposta);
            Task<GetRespostasDto> GetJogoUsuarioByJogoIdAndUsuarioId(int jogoId, int usuarioId);

    }



}