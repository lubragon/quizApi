
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class JogoUsuario() : ModelBase
    {
        public DateTime? DataJogo { get; set; }

        public Quiz? Quiz { get; set; }

        public Usuario? Usuario { get; set; }


    }



}