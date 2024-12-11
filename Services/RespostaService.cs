using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using Elevate.QuizApi.Dominio.DTOs;


namespace Elevate.QuizApi.Services
{

    public class RespostaService : IRespostaService
    {

        private readonly IRespostaRepository _respostaRepository;

        public RespostaService(IRespostaRepository respostaRepository)
        {
            _respostaRepository = respostaRepository;
        }

        public Task<IList<RespostaDto>> GetAllRespostasByPerguntaId(int id)
        {
            return _respostaRepository.GetAllRespostasByPerguntaId(id);
        }

        public Task<Resposta> GetRespostaById(int id)
        {
            return _respostaRepository.GetRespostaById(id);
        }


    }
}