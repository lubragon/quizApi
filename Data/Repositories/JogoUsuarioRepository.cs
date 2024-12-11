using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Elevate.QuizApi.Dominio.DTOs;


namespace Elevate.QuizApi.Data.Repositories
{


    public class JogoUsuarioRepository : IJogoUsuarioRepository
    {
        private readonly Context _context;

        public JogoUsuarioRepository(Context context)
        {
            _context = context;
        }

        public virtual async Task<JogoUsuario> CriarJogoUsuario(JogoUsuario obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new Exception("JogoUsuario nulo");
                }

                _context.JogosUsuarios.Add(obj);
                await _context.SaveChangesAsync();
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar o jogo do usuário", ex);
            }
        }

        public Task<JogoUsuarioDto> CriarJogoUsuario(JogoUsuarioDto jogoUsuarioDto, int idQuiz, int idJogo)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<JogoUsuario> DeletarJogoUsuarioById(int id)
        {
            try
            {
                var jogoUsuario = await _context.JogosUsuarios.FindAsync(id);
                if (jogoUsuario == null)
                {
                    throw new InvalidOperationException($"Jogo do usuário com ID {id} não foi encontrado.");
                }
                _context.JogosUsuarios.Remove(jogoUsuario);
                await _context.SaveChangesAsync();
                return jogoUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o jogo do usuário", ex);
            }
        }

        public virtual async Task<GetRespostasDto> GetJogoUsuarioByJogoIdAndUsuarioId(int jogoId, int usuarioId)
        {
            try
            {
                var jogoUsuario = await _context.JogosUsuarios
                    .Where(ju => ju.IdJogo == jogoId)
                    .Where(ju => ju.IdUsuario == usuarioId)
                    .Include(r => r.Resposta)
                    .ToListAsync();

                if (jogoUsuario == null)
                {
                    throw new InvalidOperationException($"Erro ao buscar respostas.");
                }

                GetRespostasDto resultado = new GetRespostasDto
                {
                    TotalCorretas = jogoUsuario.Count((jogo) => jogo.Resposta[0].IsCorreta),
                    TotalRespostas = jogoUsuario.Count()
                };

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o jogo do usuário pelo ID", ex);
            }
        }

        public virtual async Task<List<JogoUsuario>> GetTodosJogosUsuarios()
        {
            try
            {
                var listaJogoUsuarios = await _context.JogosUsuarios.Include(ju => ju.Usuario).Include(ju => ju.Resposta).ToListAsync();
                if (listaJogoUsuarios == null)
                {
                    throw new Exception("JogoUsuario não nulo");
                }


                return listaJogoUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter todos os jogos dos usuários", ex);
            }
        }


    }
}
