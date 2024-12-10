using System.Reflection.Metadata;
using System.Text.Json.Serialization;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class RespostaDto : ModelBaseDto
    {
        public string Texto { get; set; }
        public bool IsCorreta { get; set; }
        public int IdPergunta { get; set; }
        public RespostaDto()
        {

        }

        public RespostaDto(Resposta resposta)
        {
            Id = resposta.Id;
            Texto = resposta.Texto;
            IdPergunta = resposta.IdPergunta;

        }

    }

}