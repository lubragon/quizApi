

using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class UsuarioDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string HashSenha { get; set; }

        public IList<Quiz> Quizzes {get; set;}
        public IList<Resposta> Respostas { get; set; }

        public UsuarioDto()
        {

        }

        public UsuarioDto(Usuario usuario)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Email = usuario.Email;
            HashSenha = usuario.HashSenha;

            Quizzes = usuario.Quizzes;
            //ToDo placar
            //Placares = usuario.Placar;
            Respostas = usuario.Respostas;

        } 
    }

}