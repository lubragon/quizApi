using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Image : ModelBase
    {

        public string Caminho { get; set; }

        public Quiz Quiz { get; set; }
        public Pergunta Pergunta { get; set; }

    }


}