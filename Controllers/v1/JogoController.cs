using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


//using Elevate.QuizApi.Utils;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Elevate.QuizApi.Controllers.v1
{
	//[Authorize]
	public class JogoController : BaseController
	{
					private readonly IJogoService _jogoService;

					public JogoController(IJogoService jogoService)
					{
									_jogoService = jogoService;
					}

        [HttpPost]
        [Route("criarJogo/{idQuiz}")]
        public async Task<IActionResult> CriarJogo(int idQuiz)
        {
            
						var jogo = new Jogo(idQuiz);
						return  Ok(await _jogoService.CriarJogo(jogo, idQuiz));

        }

				[HttpPut]
        [Route("iniciarJogo/{jogoId}")]
				public async Task<IActionResult> IniciarJogoById(int jogoId)
        {
						return  Ok(await _jogoService.IniciarJogoById(jogoId));
        }

				
	}
}