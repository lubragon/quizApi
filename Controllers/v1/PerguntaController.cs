


using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Controllers.v1
{

        public class PerguntaController : BaseController
        {
                private readonly IPerguntaService _perguntaService;

                public PerguntaController(IPerguntaService perguntaService)
                {
                        _perguntaService = perguntaService;
                }

                [HttpPost]
                [Route("adicionarPergunta/{idQuiz}")]
                public async Task<IActionResult> AdicionarPergunta(PerguntaDto perguntaDto, int idQuiz)
                {
                        var pergunta = new Pergunta(perguntaDto, idQuiz);
                        return  Ok(await _perguntaService.AdicionarPergunta(pergunta));
                }

                       


        }
}