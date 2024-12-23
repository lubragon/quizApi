
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{

    public class JogoUsuarioDto : ModelBaseDto
    {
        //public DateTime? DataJogo { get; set; }

        public string? JogadorAvulso {get; set;}
        public int? PontuacaoFinal { get; set; }
        public int? IdUsuario {get; set;}
        //public Usuario? Usuario { get; set; }

        public int IdJogo { get; set; }
        //public IList<Resposta> Resposta { get; set; } = [];
        public JogoUsuarioDto()
        {

        }

        // public JogoUsuarioDto(JogoUsuario jogoUsuario)
        // {
        //     Id = jogoUsuario.Id;
        //     IdUsuario = jogoUsuario.IdUsuario;
        //     IdResposta = jogoUsuario.IdResposta;
        //     IdJogo = jogoUsuario.IdJogo;
        // }


    }   

}