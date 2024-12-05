
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{

    public class JogoUsuarioDto : ModelBaseDto
    {
        public DateTime? DataJogo { get; set; }

        public Usuario Usuario { get; set; }

        public Quiz Quiz { get; set; }

        public JogoUsuarioDto()
        {

        }

        public JogoUsuarioDto(JogoUsuario jogoUsuario)
        {
            Id = jogoUsuario.Id;
            DataJogo = jogoUsuario.DataJogo;
            Usuario = jogoUsuario.Usuario;
            Quiz = jogoUsuario.Quiz;
        }


    }   

}