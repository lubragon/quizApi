


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


                [HttpGet]
                [Route("getPerguntaById")]
                public async Task<IActionResult> GetPerguntaById(int idPergunta)
                
                        => Ok(await _perguntaService.GetPerguntaById(idPergunta));
                
                [HttpGet]
                [Route("getAllPerguntasByQuizId")]
                public async Task<IActionResult> GetAllPerguntasByQuizId(int idQuiz)
                
                        => Ok(await _perguntaService.GetAllPerguntasByQuizId(idQuiz));
                
                [HttpGet]
                [Route("deletarPerguntaById")]
                public async Task<IActionResult> DeletarPerguntaById(int idPergunta)
                
                        => Ok(await _perguntaService.DeletarPerguntaById(idPergunta));
                
                [HttpPatch]
                [Route("editarPerguntaById")]
                public async Task<IActionResult> EditarPerguntaById(PerguntaDto perguntaDto, int idPergunta)
                {
                        var pergunta = new Pergunta(perguntaDto, idPergunta);
                        return Ok (await _perguntaService.EditarPerguntaById(pergunta, idPergunta ));
                }
                        
                

        }
}