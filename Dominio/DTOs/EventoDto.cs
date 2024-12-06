
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Enums;

namespace Elevate.QuizApi.Dominio.DTOs
{

    public class EventoDto : ModelBaseDto
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public string Titulo { get; set; }

        public StatusEventoEnum Status { get; set; }
        public string Descricao { get; set; }
    
        public IList<Quiz> Quiz { get; set; } = [];


        public EventoDto(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
        }

        public EventoDto(Evento evento)
        {
            Id = evento.Id;
            DataInicio = evento.DataInicio;
            DataFim = evento.DataFim;
            Titulo = evento.Titulo;
            Status = evento.Status;
            Descricao = evento.Descricao;
        }


        public EventoDto()
        {
            
        }
    }



}