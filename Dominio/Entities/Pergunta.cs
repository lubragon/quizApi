
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Pergunta: ModelBase 
    {

        
        public string Texto { get; set; }
        public IList<Resposta> Respostas { get; set; } = [];
        public int IdQuiz {get; set;}

        public Pergunta(string texto)
        {
            Texto = texto;

        }

        public Pergunta(string texto, IList<Resposta> respostas)
        {
            Texto = texto;
            Respostas = respostas;
        }

        public Pergunta(PerguntaDto perguntaDto, int idQuiz)
        {
            Id = perguntaDto.Id;
            Texto = perguntaDto.Texto;
            IdQuiz = idQuiz;
            Respostas = perguntaDto.RespostasDto.Select(r => new Resposta(r.Texto, r.IsCorreta)).ToList();
        }
        // TODO ESTOU TESTANDO A INSERCAO LA NO PROGRAM, VERIFICAR PROBLEMA DE CONTRUTOR E PARAMETRO


    }
}