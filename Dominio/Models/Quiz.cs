
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Quiz : ModelBase
    {

        public string Titulo {get; set;}
        public TipoQuizEnum Tipo { get; set; }

        public int QuantidadePerguntaPorQuiz { get; set; }
        public IList<Pergunta> Perguntas { get; set; } = [];

        public TimeSpan TempoTotalQuiz { get; set; }

        public int IdEvento { get; set; }

        //public Evento? Evento { get; set; }
        public IList<Jogo> Jogo {get; set;} = [];
        public Quiz(string titulo, TipoQuizEnum tipo)
        {
            Titulo = titulo;
            Tipo = tipo;

        }
        
        public Quiz()
        {
            
        }

        public Quiz(QuizDto quizDto)
        {
            Id = quizDto.Id;
            Tipo = quizDto.Tipo;
            Titulo = quizDto.Titulo;
            QuantidadePerguntaPorQuiz = quizDto.QuantidadePerguntaPorQuiz;
            Perguntas = quizDto.Perguntas.Select(p => new Pergunta(p , quizDto.Id)).ToList();
            //IdEvento = idEvento;
        }
    }
}