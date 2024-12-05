
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Pergunta(string texto) : ModelBase 
    {

        
        public string Texto { get; set; } = texto;
        
        public TimeSpan? Tempo { get; set; }
        public IList<Resposta> Respostas { get; set; } = new List<Resposta>();
        // TODO: ou passando public IList<Respostas> Respostas { get; set; } = respostas;
        public Quiz? Quiz { get; set; }


    }
}