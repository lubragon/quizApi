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
									//await Groups.AddToGroupAsync(Context.ConnectionId, jogoId);
					        await Clients.All.SendAsync("JogadorEntrou", message);
									//Console.WriteLine($"Jogador {jogadorNome} entrou no jogo {jogoId}");
							}
							catch (Exception ex)
							{
									Console.WriteLine($"Erro no método EntrarNoJogo: {ex.Message}");
									throw;
							}
					}
					public async Task IniciarJogo(string jogoId)
					{
							await Clients.All.SendAsync("JogoIniciado", $"Jogo {jogoId} foi iniciado");
							Console.WriteLine($"Notificação de início enviada para o grupo {jogoId}");
			    }

				// Verificar se todo mundo jha respondeu

				
	}
}