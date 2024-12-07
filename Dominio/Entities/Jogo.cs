
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Jogo : ModelBase
    {
        public int IdQuiz {get; set;}
        public Quiz? Quiz { get; set; }

        public IList<JogoUsuario> JogoUsuario { get; set; } = [];

        public Jogo()
        {

        }
        public Jogo(JogoDto jogoDto)
        {
            Id = jogoDto.Id;
            IdQuiz = jogoDto.IdQuiz;
            
        }
    }




}