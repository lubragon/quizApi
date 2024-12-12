using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Elevate.QuizApi.Dominio.DTOs;


namespace Elevate.QuizApi.Data.Repositories
{

    public class UsuarioRepository : IUsuarioRepository
    {

        public readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }

        public virtual async Task<Usuario> CriarUsuario(Usuario obj)
        {
            try
            {

                _context.Usuarios.Add(obj);
                await _context.SaveChangesAsync();
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar o usuário", ex);
            }
        }


        public virtual async Task<Usuario> DeletarUsuarioById(int id)
        {
            try
            {
                var usuario = await _context.Usuarios.FindAsync(id);
                if (usuario == null)
                {
                    throw new Exception($"Usuário com ID {id} não foi encontrado.");
                }
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o usuário", ex);
            }
        }

        public virtual async Task<Usuario> EditarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = await _context.Usuarios.FindAsync(usuario.Id);
                if (usuarioExistente == null)
                {
                    throw new Exception($"Usuário com ID {usuario.Id} não foi encontrado.");
                }
                usuarioExistente = usuario;
                _context.Usuarios.Update(usuarioExistente);
                await _context.SaveChangesAsync();
                return usuarioExistente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao editar o usuário", ex);
            }
        }

        public virtual async Task<Usuario> GetUsuarioById(int id)
        {
            try
            {

                var usuario = await _context.Usuarios.FindAsync(id);
                
                if(usuario == null)
                {
                    throw new Exception("Usuário nulo");

                }

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o usuário pelo ID", ex);
            }
        }

        public virtual async Task<UsuarioDto> GetUsuarioByEmail(string email)
        {
            try
            {
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
                if(usuario == null)
                {
                    throw new Exception("Usuário nulo");
                }
                var usuarioDto = new UsuarioDto(usuario);
                return usuarioDto;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o usuário pelo email", ex);
            }
        }

        public virtual async Task<List<Usuario>> GetUsuarioByNome(string nome)
        {
            try
            {
                var usuario = await _context.Usuarios.Where(u => u.Nome.Contains(nome)).ToListAsync();
                if(usuario == null)
                {
                    throw new Exception("Usuário nulo");
                }
                
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o usuário pelo nome", ex);
            }
        }

        public virtual async Task<Usuario> GetByLogin(string login)
        {
            try
            {
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Login == login);
            
                return usuario;
                

            }
            catch(Exception e)
            {
                throw new Exception("Erro ao obter usuário");
            }
        }

            public async Task<UsuarioDto> Insert(UsuarioDto usuarioDto)
        {
            try
            {   var usuario = new Usuario(usuarioDto);
                if (usuario is null)
                    return null;

                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();

                var user = new UsuarioDto(usuario);

                return user;
            }
            catch (Exception e)
            {
                throw new Exception("Error insert");
            }
        }
    }



}