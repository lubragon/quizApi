using Elevate.QuizApi.Controllers.Hubs;
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Data.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly Context _context;
        private readonly QuizHub _hubContext;

        public JogoRepository(Context context, QuizHub hubContext)
        {
            _context = context;
            _hubContext = hubContext;

        }
        public virtual async Task<Jogo> CriarJogo(Jogo jogo, int idQuiz)
        {
        
            try
            {
                                
                _context.Jogos.Add(jogo);
                await _context.SaveChangesAsync();

                return jogo;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao criar jogo", ex);

            }
        }

        public virtual async Task<Jogo> DeletarJogoById(int id)
        {
            try
            {
                var jogo = await _context.Jogos.FindAsync(id);
                if (jogo == null)
                {
                    throw new InvalidOperationException($"Jogo com ID {id} não foi encontrado.");
                }
                _context.Jogos.Remove(jogo);
                await _context.SaveChangesAsync();
                return jogo;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar o jogo", ex);
            }
        }

        
        public virtual async Task<Jogo> GetJogoById(int id)
        {
            try
            {
                var jogo = await _context.Jogos.Include(j => j.JogoUsuarios).FirstOrDefaultAsync(j => j.Id == id);

                if(jogo == null)
                {
                    throw new Exception ("Jogo não encontrado");
                };
                return jogo;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o jogo pelo ID", ex);
            }
        }

        public virtual async Task<List<Jogo>> GetTodosJogos()
        {
            try
            {
                return await _context.Jogos.Include(j => j.JogoUsuarios).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter todos os jogos", ex);
            }
        }

        public virtual async Task<Jogo> IniciarJogoById(int jogoId)
        {
            try
            {
                var jogo = await _context.Jogos.Include(j => j.JogoUsuarios).FirstOrDefaultAsync(j => j.Id == jogoId);

                if (jogo == null)
                {
                    throw new Exception($"Jogo com ID {jogoId} não encontrado.");
                }

                if (jogo.IsJogoIniciado)
                {
                    throw new Exception($"Jogo com ID {jogoId} já foi iniciado.");
                }

                jogo.IsJogoIniciado = true;

                _context.Jogos.Update(jogo);
                await _context.SaveChangesAsync();
 

                return jogo;

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao iniciar jogo", ex);
            }
        }

    }


}