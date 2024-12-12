using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
//using Elevate.QuizApi.Utils;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Data.Repositories
{
	public class LoginRepository : ILoginRepository
	{
		private readonly Context _context;

		public LoginRepository(Context context)
		{
			_context = context;
		}
		

		public virtual async Task<Usuario> GetAllRespostasByPerguntaId(string email)
		{
			try
			{
				var usuario = _context.Usuarios.FirstAsync(u => u.Email == email);
				if (usuario == null){
					throw new Exception("Erro de autenticação");
				}
				return await usuario;
			}
			catch(Exception ex)
			{
				throw new Exception("", ex);
			}
		}

	}      
}