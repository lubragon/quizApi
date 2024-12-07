using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Controllers.v1
{

        public class UsuarioController : BaseController
        {
                private readonly IUsuarioService _usuarioService;

                public UsuarioController(IUsuarioService usuarioService)
                {
                        _usuarioService = usuarioService;
                }

                [HttpPost]
                [Route("criarUsuario")]
                public async Task<IActionResult> CriarUsuario(UsuarioDto obj)
                {
                        var usuario = new Usuario(obj);
                        return  Ok(await _usuarioService.CriarUsuario(usuario));
                }
        }
}