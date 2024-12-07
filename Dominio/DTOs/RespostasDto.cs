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

        public RespostaDto(Resposta resposta, int idPergunta)
        {
            Id = resposta.Id;
            Texto = resposta.Texto;
            IsCorreta = resposta.IsCorreta;
            IdPergunta = idPergunta;

        }

    }

}