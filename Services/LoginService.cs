using Microsoft.AspNetCore.Mvc.Formatters;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using Elevate.QuizApi.Dominio.DTOs;


namespace Elevate.QuizApi.Services
{

    public class LoginService : ILoginService
    {

        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        // public Task<IList<RespostaDto>> GetAllRespostasByPerguntaId(int id)
        // {
        //     return _respostaRepository.GetAllRespostasByPerguntaId(id);
        // }

        // public Task<Resposta> GetRespostaById(int id)
        // {
        //     return _respostaRepository.GetRespostaById(id);
        // }


    }

}