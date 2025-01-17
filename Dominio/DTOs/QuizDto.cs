using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class QuizDto : ModelBaseDto
    {
        public string Titulo {get; set;}
        public TipoQuizEnum? Tipo { get; set; }
        public int QuantidadePerguntaPorQuiz { get; set; }

        public IList<PerguntaDto> Perguntas { get; set; } = [];
        //public int IdEvento { get; set; }
        public QuizDto(string titulo, TipoQuizEnum tipo)
        {
            Titulo = titulo;
            Tipo = tipo;

        }

        public QuizDto()
        {

        }

        public QuizDto(Quiz quiz)
        {
            Id = quiz.Id;
            Tipo = quiz.Tipo;
            Titulo = quiz.Titulo;
            QuantidadePerguntaPorQuiz = quiz.QuantidadePerguntaPorQuiz;
            Perguntas =  quiz?.Perguntas != null ? quiz.Perguntas.Select(p => new PerguntaDto(p,quiz.Id)).ToList() : new List<PerguntaDto>();
            //IdEvento = idEvento;

        }
    }

}