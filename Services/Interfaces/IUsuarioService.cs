using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.DTOs;

namespace Elevate.QuizApi.Services.Interfaces
{

    public interface IUsuarioService
    {
        Task<Usuario> CriarUsuario(Usuario usuario);
        Task<Usuario> GetUsuarioById(int idUsuario); 
        Task<UsuarioDto> GetUsuarioByEmail(string emailUsuario); 
        Task<Usuario> CriarUsuarioAdministrador(Usuario usuarioDto); 

        Task<Usuario> GetByLogin (string login);
        Task<UsuarioDto> Insert(UsuarioDto usuario);


    }
}