using System.Reflection.Metadata;
using quizApi.Dominio.Enums;
using QuizApi.Dominio.Entities;

namespace QuizApi.Dominio.DTOs
{

    public class EventoDto
    {
        public int Id { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public string Titulo { get; set; }

        public StatusEventoEnum Status { get; set; }
        public string Descricao { get; set; }
    
        public IList<Quiz> Quiz { get; set; }


        public EventoDto()
        {
            
        }

        public EventoDto(Evento evento)
        {
            Id = evento.Id;
            DataInicio = evento.DataInicio;
            DataFim = evento.DataFim;
            Titulo = evento.Titulo;
            Status = evento.Status;
            Descricao = evento.Descricao;
            Quiz = evento.Quizzes;
        }
    }



}