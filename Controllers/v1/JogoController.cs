using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


//using Elevate.QuizApi.Utils;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Elevate.QuizApi.Controllers.v1
{

	public class JogoController : BaseController
	{
					private readonly IJogoService _jogoService;

					public JogoController(IJogoService jogoService)
					{
									_jogoService = jogoService;
					}

        [HttpPost]
        [Route("criarJogo")]
        public async Task<IActionResult> CriarJogo(JogoDto jogoDto, int idQuiz)
        {
            if (jogoDto == null)
            {
                return BadRequest("Jogo é nulo.");
            }
						var jogo = new Jogo(jogoDto, idQuiz);
						return  Ok(await _jogoService.CriarJogo(jogo, idQuiz));

        }
				
	}
}