using System.Reflection.Metadata;
using quizApi.Dominio.Models;

namespace QuizApi.Dominio.Entities
{
    public class Resposta(string texto, bool isCorreta) : ModelBase
    {


        public string Texto { get; set; } = texto;
        public bool IsCorreta { get; set; } = isCorreta;

        public Pergunta? Pergunta { get; set; }
        public IList<Usuario> Usuario { get; set; } = new List<Usuario>();
        // TODO
    }
} 