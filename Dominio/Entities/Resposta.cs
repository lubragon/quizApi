using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Resposta : ModelBase
    {


        public string Texto { get; set; }
        public bool IsCorreta { get; set; }

        public int IdPergunta { get; set; }


        public Resposta(int id)
        {
            Id = id;
        }
        public Resposta(string texto, bool isCorreta)
        {
            Texto = texto;
            IsCorreta = isCorreta;

        }

        public Resposta(RespostaDto respostaDto, int idPergunta)
        {
            Id = respostaDto.Id;
            Texto = respostaDto.Texto;
            IsCorreta = respostaDto.IsCorreta;
            IdPergunta = idPergunta;
        }
    }
} 