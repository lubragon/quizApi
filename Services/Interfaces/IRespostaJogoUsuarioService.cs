using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IRespostaJogoUsuarioService
    {
        Task<RespostaJogoUsuario> CriarRespostaJogoUsuario(RespostaJogoUsuario respostaJogoUsuario);
        Task<GetRespostasDto> GetRespostaJogoUsuarioByJogoUsuarioId(int jogoUsuarioId);
    }




}