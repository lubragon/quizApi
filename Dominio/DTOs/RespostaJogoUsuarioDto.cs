using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class RespostaJogoUsuarioDto 
    {

        public int IdResposta { get; set; }
        public int IdJogoUsuario { get; set; }
        public RespostaJogoUsuarioDto()
        {

        }

        public RespostaJogoUsuarioDto(RespostaJogoUsuario respostaJogoUsuario)
        {
            IdResposta = respostaJogoUsuario.IdResposta;
            IdJogoUsuario = respostaJogoUsuario.IdJogoUsuario;
        }







    }







}