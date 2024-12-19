using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Controllers.v1
{
        //[Authorize]
        public class QuizController : BaseController
        {
                private readonly IQuizService _quizService;

                public QuizController(IQuizService quizService)
                {
                        _quizService = quizService;
                }

                [HttpPost]
                [Route("adicionarQuiz")]
                public async Task<IActionResult> AdicionarQuiz(QuizDto obj)
                {
                        var quiz = new Quiz(obj);
                        return  Ok(await _quizService.AdicionarQuiz(quiz));
                }
                
                [HttpPost]
                [Route("deletarQuizById/id={id}")]
                public async Task<IActionResult> DeletarQuizById(int id)
                        =>  Ok(await _quizService.DeletarQuizById(id));

                [HttpGet]
                [Route("getAllQuizzes")]
                public async Task<IActionResult> GetAllQuizes()
                
                        => Ok(await _quizService.GetAllQuizzes());
                
                [HttpGet]
                [Route("getQuizById")]
                public async Task<IActionResult> GetQuizById([FromQuery]  int idQuiz)
                
                        => Ok(await _quizService.GetQuizById(idQuiz));
                
                [HttpPatch]
                [Route("editarQuizById/id={id}")]
                public async Task<IActionResult> EditarQuizById(QuizDto obj, int id)
                {
                        var quiz = new Quiz(obj);
                        return  Ok(await _quizService.EditarQuizById(quiz, id));
                }

                       


        }
}