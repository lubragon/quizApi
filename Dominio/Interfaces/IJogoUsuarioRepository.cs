using Elevate.QuizApi.Dominio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IJogoUsuarioRepository
    {
        Task<JogoUsuario> CriarJogoUsuario(JogoUsuario jogoUsuario);
        Task<JogoUsuario> DeletarJogoUsuarioById(int id);
        Task<JogoUsuario> GetJogoUsuarioById(int id);
        Task<List<JogoUsuario>> GetTodosJogosUsuarios();

    }

}