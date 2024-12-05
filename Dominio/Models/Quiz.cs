
using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Quiz(TipoQuizEnum tipo, string titulo) : ModelBase
    {

        public string Titulo {get; set;} = titulo;
        public TipoQuizEnum Tipo { get; set; } = tipo;
        public IList<Pergunta> Perguntas { get; set; } = new List<Pergunta>();

        //public string ImagemCaminho { get; set; }

        //public Placar Placar {get; set;} = placar;
    
        public Evento? Evento { get; set; }

        public Jogo Jogo{ get; set; } = null!;
    
    }


}