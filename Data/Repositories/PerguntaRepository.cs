using Elevate.QuizApi.Services;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Elevate.QuizApi.Dominio.Interfaces;


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
                //Lista Resposta
                var pergunta = new Pergunta(obj.Texto)
                {
                    Texto = obj.Texto,
                    Respostas = obj.Respostas,
                    Quiz = obj.Quiz
                };

                _context.Perguntas.Add(pergunta);
                await _context.SaveChangesAsync();

                return pergunta;

        

            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao adicionar pergunta", ex);

            }
        }



                        // Texto da Pergunta
                // Tempo em segundos pra pergunta
                // Como adicionar as respostas? 
                // Definir qual resposta é a certa

                // Usar Pergunta ou PerguntaDto?

    }






}