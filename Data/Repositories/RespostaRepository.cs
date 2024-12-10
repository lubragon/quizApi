using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
//using Elevate.QuizApi.Utils;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elevate.QuizApi.Data.Repositories
{
	public class RespostaRepository : IRespostaRepository
	{
		private readonly Context _context;

		public RespostaRepository(Context context)
		{
			_context = context;
		}
		

		public virtual async Task<IList<RespostaDto>> GetAllRespostasByPerguntaId(int id)
		{
			try
			{
				var respostas = await _context.Respostas
					.Where(r => r.IdPergunta == id)
					.ToListAsync();
				if(respostas == null)
				{
					throw new Exception("Respostas nulas");
				}

        var respostasDto = respostas.Select(r => new RespostaDto(r)).ToList();

        //var respostaSemGabarito = respostasDto.Select(r => Removedor.RemoverIsCorreta(r)).ToList();


				return respostasDto;
			}
			catch(Exception ex)
			{
				throw new Exception("Erro ao obter respostas", ex);
			}
		}
	}      
}