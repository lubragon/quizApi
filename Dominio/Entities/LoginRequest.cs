using Elevate.QuizApi.Dominio.DTOs;
using Microsoft.AspNetCore.Identity.Data;

namespace Elevate.QuizApi.Dominio.Entities
{
    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    
        public LoginRequest(string email, string senha)
        {
            Email = email;
            Senha = senha;
        
        }

        public LoginRequest(LoginRequestDto loginRequestDto)
        {
            Email = loginRequestDto.Email;
            Senha = loginRequestDto.Senha; 
        }
    }



}

