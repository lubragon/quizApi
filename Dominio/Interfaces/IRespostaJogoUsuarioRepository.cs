using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IRespostaJogoUsuarioRepository
    {
        Task<RespostaJogoUsuario> CriarRespostaJogoUsuario(RespostaJogoUsuario respostaJogoUsuario);
        Task<GetRespostasDto> GetRespostaJogoUsuarioByJogoUsuarioId(int jogoUsuarioId);
    }

}