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
	public class QuizHub
	{

					private readonly IJogoUsuarioService _jogoUsuarioService;

					public QuizHub(IJogoUsuarioService jogoUsuarioService)
					{
							_jogoUsuarioService = jogoUsuarioService;									  
					}

        // Registrar no hub
				//Lista usuarios
				// Entrar na sala - Registrar no SIGNALR

				// Verificar se todo mundo jha respondeu

				
	}
}