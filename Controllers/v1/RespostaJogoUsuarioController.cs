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
	public class RespostaJogoUsuarioController : BaseController
	{
					private readonly IRespostaJogoUsuarioService _respostaJogoUsuarioService;

					public RespostaJogoUsuarioController(IRespostaJogoUsuarioService respostaJogoUsuarioService)
					{
									_respostaJogoUsuarioService = respostaJogoUsuarioService;
					}


					[HttpPost]
					[Route("responder")]
					public async Task<IActionResult> CriarRespostaJogoUsuario(RespostaJogoUsuarioDto respostaJogoUsuarioDto)
					{
							var respostaJogoUsuario = new RespostaJogoUsuario(respostaJogoUsuarioDto);
							return  Ok(await _respostaJogoUsuarioService.CriarRespostaJogoUsuario(respostaJogoUsuario));

					}

					[HttpGet]
					[Route("getRespostas")]
					public async Task<IActionResult> GetRespostaJogoUsuarioByJogoUsuarioId(int jogoUsuarioId)
								=> Ok(await _respostaJogoUsuarioService.GetRespostaJogoUsuarioByJogoUsuarioId(jogoUsuarioId));


	}
}