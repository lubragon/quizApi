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
	public class JogoUsuarioController : BaseController
	{
					private readonly IJogoUsuarioService _jogoUsuarioService;

					public JogoUsuarioController(IJogoUsuarioService jogoUsuarioService)
					{
									_jogoUsuarioService = jogoUsuarioService;
					}


					[HttpPost]
					[Route("entrarJogo")]
					public async Task<IActionResult> CriarJogoUsuario(JogoUsuarioDto jogoUsuarioDto)
					{
							var jogoUsuario = new JogoUsuario(jogoUsuarioDto);
							return  Ok(await _jogoUsuarioService.CriarJogoUsuario(jogoUsuario));

					}


					// [HttpGet]
					// [Route("getRespostasOld")]
					// public async Task<IActionResult> GetJogoUsuarioByJogoIdAndUsuarioId(int jogoId, int usuarioId)
					// 			=> Ok(await _jogoUsuarioService.GetJogoUsuarioByJogoIdAndUsuarioId(jogoId, usuarioId));

					[HttpPut]
					[Route("adicionarPontuacao")]
					public async Task<IActionResult> AdicionarPontuacaoFinal(int jogoUsuarioId, int pontuacaoFinal)
          {
              return Ok(await _jogoUsuarioService.AdicionarPontuacaoFinal(jogoUsuarioId, pontuacaoFinal));
          }

								
	}
}