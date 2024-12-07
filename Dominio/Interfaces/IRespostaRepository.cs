using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Dominio.Interfaces
{
    public interface IRespostaRepository
    {
        //Task<Jogo> CriarJogo(Jogo jogo);
        //Task<Jogo> EditarJogo(Jogo jogo);
        Task<IList<RespostaDto>> GetAllRespostasByPerguntaId(int id);

    }

}