using System.Reflection.Metadata;
using quizApi.Dominio.Enums;
using quizApi.Dominio.Models;

namespace QuizApi.Dominio.Entities
{

    public class Jogo(DateTime dataJogo) : ModelBase
    {
        public DateTime DataJogo { get; set; } = dataJogo;

        public Quiz? Quiz { get; set; }

        public IList<Usuario> Usuario { get; set; } = new List<Usuario>();


    }



}