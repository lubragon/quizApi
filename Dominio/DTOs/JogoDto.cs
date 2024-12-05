using System.Reflection.Metadata;
using QuizApi.Dominio.Entities;

namespace QuizApi.Dominio.DTOs
{

    public class JogoDto
    {
        public int Id { get; set; }
        public DateTime DataJogo { get; set; }

        public IList<Usuario> Usuario { get; set; }

        public Quiz Quiz { get; set; }

        public JogoDto()
        {

        }

        public JogoDto(Jogo jogo)
        {
            Id = jogo.Id;
            DataJogo = jogo.DataJogo;
            Usuario = jogo.Usuario;
            Quiz = jogo.Quiz;
        }


    }   

}