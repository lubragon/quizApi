using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.DTOs;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IUsuarioService
    {
        Task<Usuario> CriarUsuario(Usuario usuario);
        Task<Usuario> GetUsuarioById(int idUsuario); 
        Task<UsuarioDto> GetUsuarioByEmail(string emailUsuario); 

    }
}