using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Dominio.DTOs
{
    public class LoginRequestDto
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    
        public LoginRequestDto(string email, string senha)
        {
            Email = email;
            Senha = senha;
        
        }

        public LoginRequestDto()
        {
            
        }

        public LoginRequestDto(LoginRequest loginRequest)
        {
            Email = loginRequest.Email;
            Senha = loginRequest.Senha; 
        }
    }
}
