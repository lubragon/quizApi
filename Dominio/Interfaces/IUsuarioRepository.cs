using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.DTOs;


namespace Elevate.QuizApi.Dominio.Interfaces
{

    public interface IUsuarioRepository
    {
        Task<Usuario> CriarUsuario(Usuario usuario);

        Task<Usuario> DeletarUsuarioById (int id);
        Task<Usuario> EditarUsuario (Usuario usuario);
        Task<Usuario> GetUsuarioById(int id);
        Task<UsuarioDto> GetUsuarioByEmail(string email);        
        Task<Usuario> CriarUsuarioAdministrador(Usuario usuario); 

        Task<List<Usuario>> GetUsuarioByNome(string nome);
        Task<Usuario> GetByLogin (string login);
        Task<UsuarioDto> Insert (UsuarioDto usuario);


    }
}