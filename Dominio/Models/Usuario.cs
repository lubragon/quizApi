
using Elevate.QuizApi.Dominio.Models;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class Usuario(string nome, string email, string hashSenha) : ModelBase
    {

        public string Nome { get; set; } = nome;

        public string Email { get; set; } = email;

        public string HashSenha { get; set; } = hashSenha;

        public IList<JogoUsuario>? JogoUsuario {get; set;} = new List<JogoUsuario>();

    }



}