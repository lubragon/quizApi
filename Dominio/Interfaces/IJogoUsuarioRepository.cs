using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IJogoUsuarioRepository
    {
        Task<JogoUsuario> CriarJogoUsuario(JogoUsuario jogoUsuario);
        Task<JogoUsuario> DeletarJogoUsuarioById(int id);
        Task<GetRespostasDto> GetJogoUsuarioByJogoIdAndUsuarioId(int jogoId, int usuarioId);
        Task<List<JogoUsuario>> GetTodosJogosUsuarios();
        Task<JogoUsuario> AdicionarPontuacaoFinal(int jogoUsuarioId, int pontuacaoFinal);

    }

}