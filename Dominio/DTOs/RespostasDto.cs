using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class RespostaDto
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool IsCorreta { get; set; }

        public int IdPergunta { get; set; }
        public Pergunta Pergunta { get; set; }
        //public IList<Usuario> Usuarios { get; set; }
   

        public RespostaDto()
        {

        }

        public RespostaDto(Resposta resposta)
        {
            Id = resposta.Id;
            Texto = resposta.Texto;
            IsCorreta = resposta.IsCorreta;

            Pergunta = resposta.Pergunta;
            IdPergunta = resposta.Pergunta.Id;

            // TODO como ficaria =>             Usuarios = respostas.Usuarios.;



        }

    }

}