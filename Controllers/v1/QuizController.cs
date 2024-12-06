using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Controllers.v1
{

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

                       


        }
}