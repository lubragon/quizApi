using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class QuizDto : ModelBaseDto
    {
        public string Titulo {get; set;}
        public TipoQuizEnum Tipo { get; set; }
        public IList<Pergunta> Perguntas { get; set; } = [];
        public int IdEvento { get; set; }
        public QuizDto(string titulo, TipoQuizEnum tipo)
        {
            Titulo = titulo;
            Tipo = tipo;

        }

        public QuizDto(Quiz quiz, int idEvento)
        {
            Id = quiz.Id;
            Tipo = quiz.Tipo;
            Titulo = quiz.Titulo;
            Perguntas = quiz.Perguntas;
            IdEvento = idEvento;

        }
    }

}