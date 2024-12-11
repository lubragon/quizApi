
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IRespostaService
    {
        Task<IList<RespostaDto>> GetAllRespostasByPerguntaId(int id);
        Task<Resposta> GetRespostaById(int id);
        
    }







}