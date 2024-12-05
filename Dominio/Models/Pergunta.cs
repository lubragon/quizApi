using System.Reflection.Metadata;
using quizApi.Dominio.Models;

namespace QuizApi.Dominio.Entities
{

    public class Pergunta(string texto, TimeSpan tempo) : ModelBase 
    {

        
        public string Texto { get; set; } = texto;
        
        public TimeSpan Tempo { get; set; } = tempo;
        public IList<Resposta> Respostas { get; set; } = new List<Resposta>();
        // TODO: ou passando public IList<Respostas> Respostas { get; set; } = respostas;
        public Quiz? Quiz { get; set; }


    }
}