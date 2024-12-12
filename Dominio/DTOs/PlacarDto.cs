using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class PlacarDto 
    {

        public int Id { get; set; }
        public int IdQuiz { get; set; }

        public int Pontuacao { get; set; }
        public Quiz? Quiz { get; set; } 

        public IList<Usuario> Usuario { get; set; } = [];

        public PlacarDto()
        {

        }

        public PlacarDto(Placar placar, int idQuiz)
        {
            Id = placar.Id;
            //IdUsuario = placar.Usuario;
            IdQuiz = idQuiz;
            Pontuacao = placar.Pontuacao;
            Quiz = placar.Quiz;
            Usuario = placar.Usuario;

        }







    }







}