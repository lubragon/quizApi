using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Elevate.QuizApi.Data.Repositories
{
    public class PerguntaRepository : IPerguntaRepository
    {

        public readonly Context _context;
        public PerguntaRepository(Context context)
        {
            _context = context;
        }

        
        public virtual async Task<Pergunta> AdicionarPergunta(Pergunta obj)
        {
            try
            {
                
                _context.Perguntas.Add(obj);
                await _context.SaveChangesAsync();

                return obj;

        

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao adicionar pergunta", ex);

            }
        }

        public virtual async Task<Pergunta> GetPerguntaById(int id)
        {
            try
            {
                var pergunta = await _context.Perguntas.Include(p => p.Respostas).FirstOrDefaultAsync(p => p.Id == id);

                if(pergunta == null)
                {
                    throw new Exception("Pergunta nula");
                }


                return pergunta;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao obter pergunta", ex);
            }
        }

        public virtual async Task<Pergunta> DeletarPerguntaById(int id)
        {
            try
            {
                var pergunta = await _context.Perguntas
                    .Include(p => p.Respostas)
                    .FirstOrDefaultAsync(p => p.Id == id);

                if(pergunta == null)
                {
                    throw new InvalidOperationException("Pergunta está nula.");
                }



                _context.Perguntas.Remove(pergunta);

                await _context.SaveChangesAsync();

                return pergunta;
             
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao obter pergnta", ex);
            }
            
        }


        public virtual async Task<Pergunta> AtualizarPergunta(Pergunta obj)
        {
            try
            {
                var perguntaExistente = await _context.Perguntas.FindAsync(obj.Id);

                if(perguntaExistente == null)
                {
                    throw new InvalidOperationException($"Pergunta não encontrada.");
                }

                perguntaExistente.Texto = obj.Texto;

                _context.Perguntas.Update(perguntaExistente);
                await _context.SaveChangesAsync();

                return perguntaExistente;

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao atualizar a pergunta", ex);
            }
        }
        public virtual async Task<Pergunta> AtualizarResposta(Pergunta obj)
        {
            try
            {
                var perguntaExistente = await _context.Perguntas.FindAsync(obj.Id);

                if(perguntaExistente == null)
                {
                    throw new InvalidOperationException($"Pergunta não encontrada.");
                }

                perguntaExistente.Respostas = obj.Respostas;


                _context.Perguntas.Update(perguntaExistente);
                await _context.SaveChangesAsync();

                return perguntaExistente;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao atualizar resposta", ex);

            }
        }


        public virtual async Task<List<Pergunta>> OberPerguntasPorQuiz(int quizId)
        {
            try
            {
                return await _context.Perguntas.Include(p => p.Respostas).Where(p => p.IdQuiz == quizId).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter todas as perguntas", ex);
            }
        }

    }
}