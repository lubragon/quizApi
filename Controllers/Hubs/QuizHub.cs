using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;


//using Elevate.QuizApi.Utils;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Elevate.QuizApi.Controllers.Hubs
{
	public class QuizHub : Hub
	{

					// private readonly IJogoUsuarioService _jogoUsuarioService;

					// public QuizHub(IJogoUsuarioService jogoUsuarioService)
					// {
					// 		_jogoUsuarioService = jogoUsuarioService;									  
					// }

				  public async Task EntrarNoJogo(string message)
					{
							try
							{
					        await Clients.All.SendAsync("JogadorEntrou", message);
							}
							catch (Exception ex)
							{
									Console.WriteLine($"Erro Hub EntrarNoJogo: {ex.Message}");
									throw;
							}
					}
					public async Task IniciarJogo(string message)
					{
							try
							{
							await Clients.All.SendAsync("JogoIniciado", message);
							}
							catch (Exception ex)
							{
									Console.WriteLine($"Erro Hub JogoIniciado: {ex.Message}");
									throw;
							}
			    }

					public async Task FinalizarJogador(string nomeJogador, int pontuacaFinal) {
						try
						{
							await Clients.All.SendAsync("JogadorFinalizou",nomeJogador, pontuacaFinal); //
						}
						catch (Exception ex)
            {
                Console.WriteLine($"Erro Hub JogadorFinalizou: {ex.Message}");
                throw;
            }
					}
					
					// public async Task FinalizarJogador(string message) {
					// 	try
					// 	{
					// 		await Clients.All.SendAsync("JogadorFinalizou", message);
					// 	}
					// 	catch (Exception ex)
          //   {
          //       Console.WriteLine($"Erro Hub JogadorFinalizou: {ex.Message}");
          //       throw;
          //   }
					// }
				// Verificar se todo mundo jha respondeu
	}
}