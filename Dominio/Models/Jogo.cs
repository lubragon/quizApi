
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Jogo(DateTime dataJogo) : ModelBase
    {
        public DateTime DataJogo { get; set; } = dataJogo;

        public Quiz? Quiz { get; set; }

        public IList<Usuario> Usuario { get; set; } = new List<Usuario>();


    }



}