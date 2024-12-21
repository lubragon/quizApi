
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Jogo : ModelBase
    {
        public int IdQuiz {get; set;}
        public Quiz? Quiz { get; set; }

        public bool IsJogoIniciado { get; set; } = false;

        public IList<JogoUsuario> JogoUsuarios { get; set; } = [];

        public Jogo()
        {

        }
        public Jogo(int idQuiz)
        {
            IdQuiz = idQuiz;
        }
        public Jogo(JogoDto jogoDto, int idQuiz)
        {
            Id = jogoDto.Id;
            IdQuiz = idQuiz;
            JogoUsuarios = jogoDto.JogoUsuariosDto.Select(ju => new JogoUsuario(ju)).ToList(); // Linq atua nesses casos.
            IsJogoIniciado = jogoDto.IsJogoIniciado;
        }
    }




}