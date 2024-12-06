using Elevate.QuizApi.Data;
using Elevate.QuizApi.Data.Repositories;
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options => 
        options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 21)))
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Testes
var text = "Qual a cpital da franasdsadsca?";
var list = new List<Resposta> 
{
        new Resposta("Paris", true),
        new Resposta("B", false),
        new Resposta("C", false),
        new Resposta("D", false),
};

var pergunta = new Pergunta(text, list)
{
    Texto = text,
    Respostas = list
};


// Apenas para testes aqui TODO
var dbTeste = app.Services.CreateScope().ServiceProvider.GetService<Context>();

if(dbTeste == null)
{
    throw new Exception("Teste em Program.cs");
}

var perguntaRepo = new PerguntaRepository(dbTeste).AdicionarPergunta(pergunta);




app.Run();

