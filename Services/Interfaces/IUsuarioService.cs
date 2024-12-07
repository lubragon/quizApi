using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IUsuarioService
    {
        Task<Usuario> CriarUsuario(Usuario usuario);

    }
}