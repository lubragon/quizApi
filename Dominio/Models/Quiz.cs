using System.Reflection.Metadata;
using quizApi.Dominio.Enums;
using quizApi.Dominio.Models;

namespace QuizApi.Dominio.Entities
{
    public class Quiz(TipoQuizEnum tipo) : ModelBase
    {

        public TipoQuizEnum Tipo { get; set; } = tipo;
        public IList<Pergunta> Perguntas { get; set; } = new List<Pergunta>();

        //public string ImagemCaminho { get; set; }

        //public Placar Placar {get; set;} = placar;
    
        public Evento? Evento { get; set; }

        public Jogo Jogo{ get; set; } = null!;
    
    }


}