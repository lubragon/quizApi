using Elevate.QuizApi.Controllers;
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Elevate.QuizApi.Controllers.v1
{
    public class AuthController(ILDAPService _ldapService, IUsuarioService _usuarioService) : BaseController
    {
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(typeof(UsuarioDto), 200)]
        public async Task<IActionResult> ValidateLogin([FromBody] LoginRequestDto request)
        {
            if (request == null)
                return Unauthorized("Requisição inválida");

            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Senha))
                return Unauthorized("Informe e-mail e senha");

            var userLogin = request.Email;
            // if (userLogin.Contains('@'))
            //     userLogin = userLogin.Remove(userLogin.IndexOf('@'));

            _ldapService.Login(userLogin, request.Senha);
 
            var user = await _usuarioService.GetByLogin(userLogin);
            if (user == null)
            {
                var ldapUser = _ldapService.BuscarDadosUsuario(userLogin, request.Senha);
                if (ldapUser is null)
                    return Unauthorized("Usuário inválido");

                ldapUser.Login = userLogin;

                user = new Usuario(await _usuarioService.Insert(ldapUser));
            }

            if (user is null)
                return Unauthorized("Usuário inválido");

            var claims = new List<Claim> {
                new(ClaimTypes.NameIdentifier, user.Id.ToString() ?? ""),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Name, user.Nome),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return Ok(user);
        }

        [HttpPost]
        [Route("logoff")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok();
        }
    }
}
