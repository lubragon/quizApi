using System.Reflection.Metadata;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class PerguntaDto : ModelBaseDto
    {
        public string Texto { get; set; }
        
        public IList<RespostaDto> RespostasDto { get; set; } = [];

        public int IdQuiz { get; set; }
        
        public PerguntaDto(string texto, IList<RespostaDto> respostasDto)
        {
            Texto = texto;
            RespostasDto = respostasDto;

        }

        public PerguntaDto()
        {
            
        }

        public PerguntaDto(Pergunta pergunta, int idQuiz)
        {
            Id = pergunta.Id;
            Texto = pergunta.Texto;
            RespostasDto = pergunta.Respostas.Select(r => new RespostaDto(r, pergunta.Id)).ToList(); // Linq atua nesses casos.
            IdQuiz = idQuiz;
        }



    }






}