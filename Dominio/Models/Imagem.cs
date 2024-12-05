using System.Reflection.Metadata;
using quizApi.Dominio.Models;

namespace QuizApi.Dominio.Entities
{
    public class Image : ModelBase
    {

        public string Caminho { get; set; }

        public Quiz Quiz { get; set; }
        public Pergunta Pergunta { get; set; }

    }


}