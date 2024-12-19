
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class RespostaJogoUsuario : ModelBase
    {

        public JogoUsuario? JogoUsuario { get; set; }
        public int IdJogoUsuario { get; set; }
        public Resposta? Resposta { get; set; }

        public int IdResposta { get; set; }
        public RespostaJogoUsuario()
        {

        }
        public RespostaJogoUsuario(RespostaJogoUsuarioDto respostaJogoUsuarioDto)
        {
            IdJogoUsuario = respostaJogoUsuarioDto.IdJogoUsuario;
            IdResposta = respostaJogoUsuarioDto.IdResposta;

        }




    }



}