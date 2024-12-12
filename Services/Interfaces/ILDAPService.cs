
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{
    public interface ILDAPService
    {
        UsuarioDto BuscarDadosUsuario(string usuarioLdap, string senha);
        void Login(string usuarioLdap, string senha);
    }
}
