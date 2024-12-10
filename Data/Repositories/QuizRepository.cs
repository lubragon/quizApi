using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Elevate.QuizApi.Dominio.DTOs;


namespace Elevate.QuizApi.Data.Repositories
{


    public class QuizRepository : IQuizRepository
    {

        public readonly Context _context;

        public QuizRepository(Context context)
        {
            _context = context;
        }

        public virtual async Task<Quiz> AdicionarQuiz(Quiz quiz)
        {
            try
            {
                _context.Quizzes.Add(quiz);
                await _context.SaveChangesAsync();

                return quiz;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar o quiz", ex);
            }
        }


        public virtual async Task<Quiz> DeletarQuiz(Quiz quiz)
        {
            try
            {
                if (quiz == null)
                {
                    throw new InvalidOperationException("Quiz não encontrado.");
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

        public virtual async Task<Quiz> DeletarQuizById(int quizId)
        {
            try
            {
                var quiz = await _context.Quizzes.FindAsync(quizId);
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

        public virtual async Task<Quiz> EditarQuizById(Quiz quiz, int id)
        {
            try
            {
                var quizExistente = await _context.Quizzes.FindAsync(id);
                if (quizExistente == null)
                {
                    throw new InvalidOperationException($"Quiz com ID {id} não foi encontrado.");
                }

                quizExistente = quiz;

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

                var quiz = await _context.Quizzes
                    .Include(q => q.Perguntas)
                    .ThenInclude(p => p.Respostas)
                    .FirstOrDefaultAsync(q => q.Id == id);
                    
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


        public virtual async Task<IList<QuizDto>> GetAllQuizzes()
        {
            try
            {

                var quizzes = await _context.Quizzes.ToListAsync();
                if(quizzes == null)
                {
                    throw new Exception("Nenhum quiz encontrado");
                }

                var quizzesDto = quizzes.Select(q => new QuizDto(q)).ToList();
                return quizzesDto;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o quiz", ex);
            }
        }    




    }
}