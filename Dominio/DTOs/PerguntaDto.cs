using System.Reflection.Metadata;
using QuizApi.Dominio.Entities;

namespace QuizApi.Dominio.DTOs
{
    public class PerguntaDto
    {
        public int Id { get; set; }

        public string Texto { get; set; }
        
        public TimeSpan Tempo { get; set; }
        public ICollection<Resposta> Respostas { get; set; }

        public int IdQuiz { get; set; }
        
        public Quiz Quiz { get; set; }

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