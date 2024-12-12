



using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Controllers.v1
{

		public class LoginController : BaseController
		{
			private readonly ILoginService _loginService;

			public LoginController(ILoginService loginService)
			{
							_loginService = loginService;
			}

			// [HttpGet]
			// [Route("getAllRespostasByPerguntaId")]
			// public async Task<IActionResult> GetAllRespostasByPerguntaId(int idPergunta)

			// 				=> Ok(await _respostaService.GetAllRespostasByPerguntaId(idPergunta));
		
		
		}
}