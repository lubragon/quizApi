using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Evento(string titulo, string descricao, DateTime dataInicio) : ModelBase
    {
        public DateTime DataInicio { get; set; } = dataInicio;
        public DateTime DataFim { get; set; }

        public string Titulo { get; set; } = titulo;

        public StatusEventoEnum Status { get; set; }
        public string Descricao { get; set; } = descricao;
    
        public IList<Quiz> Quizzes { get; set; } = new List<Quiz>();
    }
}