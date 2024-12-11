
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class JogoUsuario : ModelBase
    {
        public DateTime? DataJogo { get; set; }

        public int IdUsuario {get; set;}
        public Usuario? Usuario { get; set; }
        public int IdJogo { get; set; }
        public Jogo? Jogo { get; set; }

        //public int IdResposta { get; set; }
        public IList<Resposta> Resposta { get; set; } = [];
        public JogoUsuario()
        {

        }
        public JogoUsuario(JogoUsuarioDto jogoUsuarioDto)
        {
            Id = jogoUsuarioDto.Id;
            IdUsuario = jogoUsuarioDto.IdUsuario;
            IdJogo = jogoUsuarioDto.IdJogo;
        }



    }



}