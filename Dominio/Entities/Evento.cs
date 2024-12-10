using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Enums;
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{

    public class Evento : ModelBase
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public string Titulo { get; set; }

        public StatusEventoEnum Status { get; set; }
        public string Descricao { get; set; }
    
        //public IList<Quiz> Quizzes { get; set; } = [];
    
        public Evento(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            
        }
        public Evento(EventoDto eventoDto)
        {
            Id = eventoDto.Id;
            DataInicio = eventoDto.DataInicio;
            Titulo = eventoDto.Titulo;
            Status = eventoDto.Status;
            Descricao = eventoDto.Descricao;
        }
    
    }
}