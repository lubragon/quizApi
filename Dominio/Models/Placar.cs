using System.Reflection.Metadata;
using quizApi.Dominio.Models;

namespace QuizApi.Dominio.Entities
{
    public class Placar() : ModelBase
    {

        public int Pontuacao { get; set; }

        public Quiz? Quiz { get; set; }

        public IList<Usuario>? Usuario { get; set; }

    }


}