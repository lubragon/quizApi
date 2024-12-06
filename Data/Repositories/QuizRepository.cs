using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Elevate.QuizApi.Data.Repositories
{


    public class QuizRepository : IQuizRepository
    {

        public readonly Context _context;

        public QuizRepository(Context context)
        {
            _context = context;
        }

        public virtual async Task<Quiz> AdicionarQuiz(Quiz obj)
        {
            try
            {
                var quiz = new Quiz(obj.Titulo, obj.Tipo)
                {
                    Titulo = obj.Titulo,
                    Tipo = obj.Tipo,
                };

                _context.Quizzes.Add(quiz);
                await _context.SaveChangesAsync();

                return quiz;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar o quiz", ex);
            }
        }


        public virtual async Task<Quiz> DeletarQuizById(int id)
        {
            try
            {
                var quiz = await _context.Quizzes.FindAsync(id);
                if (quiz == null)
                {
                    throw new InvalidOperationException("Quiz está nulo.");
                }

                _context.Quizzes.Remove(quiz);

                await _context.SaveChangesAsync();

                return quiz;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao obter quiz", ex);
            }
        }

        public virtual async Task<Quiz> AtualizarQuiz(Quiz obj)
        {
            try
            {
                var quizExistente = await _context.Quizzes.FindAsync(obj.Id);
                if (quizExistente == null)
                {
                    throw new InvalidOperationException($"Quiz com ID {obj.Id} não foi encontrado.");
                }

                quizExistente.Titulo = obj.Titulo;
                quizExistente.Tipo = obj.Tipo;

                _context.Quizzes.Update(quizExistente);
                await _context.SaveChangesAsync();

                return quizExistente;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o quiz", ex);
            }
        }    

        public virtual async Task<Quiz> GetQuizById(int id)
        {
            try
            {

                var quiz = await _context.Quizzes.Include(q => q.Perguntas).FirstOrDefaultAsync(q => q.Id == id);
                if(quiz == null)
                {
                    throw new Exception("Quiz está nulo");
                }


                return quiz;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o quiz", ex);
            }
        }    





    }
}