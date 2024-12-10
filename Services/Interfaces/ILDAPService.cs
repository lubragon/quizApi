
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{
    public interface ILDAPService
    {
        Usuario BuscarDadosUsuario(string usuarioLdap);
        void Login(string usuarioLdap, string senha);
        void ValidarGrupoUsuario(string usuarioLdap);
    }
}
