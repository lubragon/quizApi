using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
//using Elevate.QuizApi.Utils;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Data.Repositories
{
	public class RespostaJogoUsuarioRepository : IRespostaJogoUsuarioRepository
	{
		private readonly Context _context;

		public RespostaJogoUsuarioRepository(Context context)
		{
			_context = context;
		}
		public virtual async Task<RespostaJogoUsuario> CriarRespostaJogoUsuario(RespostaJogoUsuario respostaJogoUsuario)
		{
			try
			{
				if (respostaJogoUsuario == null)
				{
					throw new Exception("Resposta nula");
				}

				_context.RespostaJogoUsuarios.Add(respostaJogoUsuario);
				await _context.SaveChangesAsync();

				 return respostaJogoUsuario;
			}
			catch(Exception ex)
			{
				throw new Exception("Erro ao criar reposta no banco de dados",  ex);	
			}
		}
			
		public virtual async Task<GetRespostasDto> GetRespostaJogoUsuarioByJogoUsuarioId(int jogoUsuarioId)
		{
			try
			{
				var respostaJogoUsuario = await _context.RespostaJogoUsuarios
					.Where(rj => rj.IdJogoUsuario == jogoUsuarioId)
					.Include(r => r.Resposta)
					.ToListAsync();

					if (respostaJogoUsuario == null)
					{
						throw new InvalidOperationException($"Erro ao buscar respostas.");
					}

					GetRespostasDto resultado = new GetRespostasDto
					{
							TotalCorretas = respostaJogoUsuario.Count((rj) => rj.Resposta.IsCorreta),
							TotalRespostas = respostaJogoUsuario.Count()
					};

					return resultado;
			}	
			catch(Exception ex)
			{
				throw new Exception("Erro ao buscar respostas do usuario", ex);
			}
		}

	}      

}