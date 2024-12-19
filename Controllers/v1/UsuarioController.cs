using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Elevate.QuizApi.Controllers.v1
{
        [Authorize]
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

                [HttpGet]
                [Route("getUsuarioById/idUsuario={id}")]
                public async Task<IActionResult> GetUsuarioById(int id)
                        => Ok(await _usuarioService.GetUsuarioById(id));

                [HttpGet]
                [Route("getUsuarioByEmail/emailUsuario={email}")]
                public async Task<IActionResult> GetUsuarioByEmail(string email)
                        => Ok(await _usuarioService.GetUsuarioByEmail(email));

        }
}