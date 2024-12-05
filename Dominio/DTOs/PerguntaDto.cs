using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class PerguntaDto : ModelBaseDto
    {
        public string Texto { get; set; }
        
        public TimeSpan? Tempo { get; set; }
        public ICollection<Resposta> Respostas { get; set; }

        public int IdQuiz { get; set; }
        

        public PerguntaDto()
        {

        }

        public PerguntaDto(Pergunta pergunta)
        {
            Id = pergunta.Id;
            Texto = pergunta.Texto;
            Tempo = pergunta.Tempo;
            Respostas = pergunta.Respostas;
            IdQuiz = pergunta.Quiz.Id;
        }



    }






}