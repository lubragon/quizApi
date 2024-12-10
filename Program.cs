using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Elevate.QuizApi.Data;
using Elevate.QuizApi.Data.Repositories;
using Elevate.QuizApi.Dominio.DTOs;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.QuizApi.Dominio.Interfaces;
using Elevate.QuizApi.Services;
using Elevate.QuizApi.Services.Interfaces;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options => 
        options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 21)))
);

// IService Service
builder.Services.AddScoped<IQuizService, QuizService>();
builder.Services.AddScoped<IPerguntaService, PerguntaService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IRespostaService, RespostaService>();
builder.Services.AddScoped<IJogoService, JogoService>();


//IRepository Repository

builder.Services.AddScoped<IQuizRepository, QuizRepository>();
builder.Services.AddScoped<IPerguntaRepository, PerguntaRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IJogoRepository, JogoRepository>();
builder.Services.AddScoped<IJogoUsuarioRepository, JogoUsuarioRepository>();
builder.Services.AddScoped<IRespostaRepository, RespostaRepository>();

builder.Services.AddControllers()
              .AddJsonOptions(options =>
              {

                options.JsonSerializerOptions.IgnoreNullValues = true;
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
             
                    // options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    // options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                    // options.JsonSerializerOptions.WriteIndented = false;    
                    // options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Default;
                    // options.JsonSerializerOptions.AllowTrailingCommas = true;
                    // options.JsonSerializerOptions.MaxDepth = 3;
                    // options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowReadingFromString;
              });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// var ldapSettings = new LDAPSettings();
// new ConfigureFromConfigurationOptions<LDAPSettings>(Configuration.GetSection("LDAPSettings")).Configure(ldapSettings);

app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());


app.MapControllers();

app.Run();

