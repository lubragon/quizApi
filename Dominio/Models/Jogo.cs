
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Jogo() : ModelBase
    {
        public Quiz? Quiz { get; set; }

        public IList<JogoUsuario> JogoUsuario { get; set; } = new List<JogoUsuario>();


    }



}