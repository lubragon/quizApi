
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Usuario(string nome, string email, string hashSenha) : ModelBase
    {

        public string Nome { get; set; } = nome;

        public string Email { get; set; } = email;

        public string HashSenha { get; set; } = hashSenha;


        //Validar
        public IList<Quiz> Quizzes {get; set;} = new List<Quiz>();
        //public IList<Placar> Placar {get; set;} = new List<Placar>();
        // TODO Placar
        public IList<Resposta> Respostas { get; set; } = new List<Resposta>();

        public Jogo? Jogo {get; set;}
    }



}