using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class PlacarDto 
    {

        public int Id { get; set; }
        // TODO
        //public int IdUsuario { get; set; }
        public int IdQuiz { get; set; }

        public int Pontuacao { get; set; }
        public Quiz Quiz { get; set; } 

        public IList<Usuario> Usuario { get; set; }

        public PlacarDto()
        {

        }

        public PlacarDto(Placar placar)
        {
            Id = placar.Id;
            //IdUsuario = placar.Usuario;
            IdQuiz = placar.Quiz.Id;
            Pontuacao = placar.Pontuacao;
            Quiz = placar.Quiz;
            Usuario = placar.Usuario;

        }







    }







}