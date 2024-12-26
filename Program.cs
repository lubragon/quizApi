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
using QuizApi.Dominio.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Elevate.QuizApi.Controllers.Hubs;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string CorsPolicy = "AllowAll";

builder.Services.AddDbContext<Context>(options => 
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddTransient<QuizHub>();

// IService Service
builder.Services.AddScoped<IQuizService, QuizService>();
builder.Services.AddScoped<IPerguntaService, PerguntaService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IRespostaService, RespostaService>();
builder.Services.AddScoped<IJogoService, JogoService>();
builder.Services.AddScoped<IJogoUsuarioService, JogoUsuarioService>();
builder.Services.AddScoped<ILDAPService, LdapService>();
builder.Services.AddScoped<IRespostaJogoUsuarioService, RespostaJogoUsuarioService>();



//IRepository Repository
builder.Services.AddScoped<IQuizRepository, QuizRepository>();
builder.Services.AddScoped<IPerguntaRepository, PerguntaRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IJogoRepository, JogoRepository>();
builder.Services.AddScoped<IJogoUsuarioRepository, JogoUsuarioRepository>();
builder.Services.AddScoped<IRespostaRepository, RespostaRepository>();
builder.Services.AddScoped<IJogoUsuarioRepository, JogoUsuarioRepository>();
builder.Services.AddScoped<IRespostaJogoUsuarioRepository, RespostaJogoUsuarioRepository>();


builder.Services.AddControllers()
              .AddJsonOptions(options =>
              {

                options.JsonSerializerOptions.IgnoreNullValues = true;
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;

             });
builder.Services.AddCors(options =>
        {
            options.AddPolicy(CorsPolicy,
            builder =>
            {
                builder
                    //.WithOrigins("http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .SetIsOriginAllowed( _ => true );
            });
        });


builder.Services.AddSignalR()
             .AddHubOptions<QuizHub>(options =>
              {
                options.EnableDetailedErrors = true;
              });


var ldapSettings = builder.Configuration.GetSection("LdapSettings").Get<LdapSettings>() ?? new();
var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>() ?? new();
var sameSiteMode = Enum.Parse<SameSiteMode>(appSettings.SameSiteMode);
var cookieSecurePolicy = Enum.Parse<CookieSecurePolicy>(appSettings.CookieSecurePolicy);


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
                options =>
                {
                    options.SlidingExpiration = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(appSettings.ExpireTokenInMinutes);
                    options.Cookie.SameSite = sameSiteMode;
                    options.Cookie.SecurePolicy = cookieSecurePolicy;
                    options.Cookie.Name = "QuizCookie";
                    options.Events.OnRedirectToLogin = context =>
                    {
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        return Task.CompletedTask;
                    };
                });    
    
builder.Services.AddSingleton(appSettings);
builder.Services.AddSingleton(ldapSettings);



var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.UseCors(CorsPolicy);

app.MapHub<QuizHub>("/QuizHub");



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}



app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());


app.MapControllers();

app.Run();

