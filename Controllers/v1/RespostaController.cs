



using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Controllers.v1
{

		public class RespostaController : BaseController
		{
			private readonly IRespostaService _respostaService;

			public RespostaController(IRespostaService respostaService)
			{
							_respostaService = respostaService;
			}

			[HttpGet]
			[Route("getAllRespostasByPerguntaId")]
			public async Task<IActionResult> GetAllRespostasByPerguntaId(int idPergunta)

							=> Ok(await _respostaService.GetAllRespostasByPerguntaId(idPergunta));
		
		
		}
}