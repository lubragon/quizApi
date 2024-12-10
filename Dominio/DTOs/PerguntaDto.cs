using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class PerguntaDto : ModelBaseDto
    {
        public string Texto { get; set; }
        
        public IList<RespostaDto> Respostas { get; set; } = [];

        public int IdQuiz { get; set; }
        
        public PerguntaDto(string texto, IList<RespostaDto> respostas)
        {
            Texto = texto;
            Respostas = respostas;

        }

        public PerguntaDto()
        {
            
        }

        public PerguntaDto(Pergunta pergunta, int idQuiz)
        {
            Id = pergunta.Id;
            Texto = pergunta.Texto;
            IdQuiz = idQuiz;
            Respostas =  pergunta?.Respostas != null ?  pergunta.Respostas.Select(r => new RespostaDto(r)).ToList() : new List<RespostaDto>(); // Linq atua nesses casos.
        }



    }






}