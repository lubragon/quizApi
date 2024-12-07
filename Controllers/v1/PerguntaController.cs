


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
                [Route("adicionarPergunta/idQuiz={idQuiz}")]
                public async Task<IActionResult> AdicionarPergunta(PerguntaDto perguntaDto, int idQuiz)
                {
                        var pergunta = new Pergunta(perguntaDto, idQuiz);
                        return  Ok(await _perguntaService.AdicionarPergunta(pergunta));
                }


                [HttpGet]
                [Route("getPerguntaById/idPergunta={id}")]
                public async Task<IActionResult> GetPerguntaById(int id)
                
                        => Ok(await _perguntaService.GetPerguntaById(id));
                
                [HttpGet]
                [Route("getAllPerguntasByQuizId/idQuiz={idQuiz}")]
                public async Task<IActionResult> GetAllPerguntasByQuizId(int idQuiz)
                
                        => Ok(await _perguntaService.GetAllPerguntasByQuizId(idQuiz));
                
                [HttpGet]
                [Route("deletarPerguntaById/idPergunta={id}")]
                public async Task<IActionResult> DeletarPerguntaById(int id)
                
                        => Ok(await _perguntaService.DeletarPerguntaById(id));
                
                [HttpPatch]
                [Route("editarPerguntaById/idPergunta={id}")]
                public async Task<IActionResult> EditarPerguntaById(PerguntaDto perguntaDto, int id)
                {
                        var pergunta = new Pergunta(perguntaDto, id);
                        return Ok (await _perguntaService.EditarPerguntaById(pergunta, id ));
                }
                        
                

        }
}