using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IJogoUsuarioRepository
    {
        Task<JogoUsuarioDto> CriarJogoUsuario(JogoUsuarioDto jogoUsuarioDto, int idQuiz, int idJogo);
        Task<JogoUsuario> DeletarJogoUsuarioById(int id);
        //Task<JogoUsuario> GetJogoUsuarioById(int id);
        Task<List<JogoUsuario>> GetTodosJogosUsuarios();

    }

}