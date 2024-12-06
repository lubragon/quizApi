using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Data.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly Context _context;

        public JogoRepository(Context context)
        {
            _context = context;
        }
        public virtual async Task<Jogo> CriarJogo(Jogo obj)
        {
            try
            {

                _context.Jogos.Add(obj);
                await _context.SaveChangesAsync();
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar o jogo", ex);
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
                var jogo = await _context.Jogos.Include(j => j.JogoUsuario).FirstOrDefaultAsync(j => j.Id == id);

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
                return await _context.Jogos.Include(j => j.JogoUsuario).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter todos os jogos", ex);
            }
        }



    }


}