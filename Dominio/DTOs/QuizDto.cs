using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class QuizDto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Titulo {get; set;}
        public TipoQuizEnum Tipo { get; set; }
        public List<Pergunta> ListaPergunta { get; set; }

        //public string ImagemCaminho { get; set; }

        public TimeSpan TempoTotalQuiz { get; set; }
    
        public Placar Placar {get; set;}

        public IList<Pergunta> Perguntas { get; set; }
    
        // TODO: Mantém essas id?
        public int IdUsuario { get; set; }
        public int IdEvento { get; set; }

        public IList<Usuario> Usuario { get; set; }

        public Evento Evento { get; set; }
   

        public QuizDto()
        {

        }

        public QuizDto(Quiz quiz)
        {
            Id = quiz.Id;
            Tipo = quiz.Tipo;
            Titulo = quiz.Titulo;
            Perguntas = quiz.Perguntas;
            IdEvento = quiz.Evento.Id;
            Evento = quiz.Evento;

        }
    }

}