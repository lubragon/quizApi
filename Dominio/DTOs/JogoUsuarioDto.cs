
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{

    public class JogoUsuarioDto : ModelBaseDto
    {
        public DateTime? DataJogo { get; set; }

        public int IdUsuario {get; set;}
        //public Usuario? Usuario { get; set; }

        public int IdJogo { get; set; }
        public int IdResposta { get; set; }
        public IList<Resposta> Resposta { get; set; } = [];
        public JogoUsuarioDto()
        {

        }

        public JogoUsuarioDto(JogoUsuario jogoUsuario, int idUsuario, int idJogo)
        {
            Id = jogoUsuario.Id;
            IdUsuario = idUsuario;
            IdResposta = jogoUsuario.IdResposta;
            IdJogo = idJogo;
        }


    }   

}