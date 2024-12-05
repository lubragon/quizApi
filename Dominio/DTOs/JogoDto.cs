
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{

    public class JogoDto :ModelBaseDto
    {
        public Quiz Quiz { get; set; }

        public JogoDto()
        {

        }

        public JogoDto(Jogo jogo)
        {
            Id = jogo.Id;
            Quiz = jogo.Quiz;
        }


    }   

}