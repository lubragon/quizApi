
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{

    public class JogoDto : ModelBaseDto
    {
        public int IdQuiz { get; set; }
        //public Quiz? Quiz { get; set; }
        public bool IsJogoIniciado { get; set; }

        public IList<JogoUsuarioDto> JogoUsuariosDto { get; set; } = [];


        public JogoDto()
        {

        }

        public JogoDto(Jogo jogo, int idQuiz)
        {
            Id = jogo.Id;
            IdQuiz = idQuiz;
            IsJogoIniciado = jogo.IsJogoIniciado;
        }


    }   

}