using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Elevate.QuizApi.Data.Mappings;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Data
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pergunta> Perguntas { get; set; } = null!;
        public DbSet<Quiz> Quizzes { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Jogo> Jogos { get; set; } = null!;
        public DbSet<JogoUsuario> JogosUsuarios { get; set; } = null!;
        public DbSet<Resposta> Respostas { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuizMap());
            modelBuilder.ApplyConfiguration(new PerguntaMap());
            modelBuilder.ApplyConfiguration(new RespostasMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EventoMap());
            modelBuilder.ApplyConfiguration(new JogoUsuarioMap());


            //modelBuilder.ApplyConfiguration(new PlacarMap());
            // TODO VALIDAR

            base.OnModelCreating(modelBuilder);

            var utcConverter = new ValueConverter<DateTime, DateTime>(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.IsKeyless)
                {
                    continue;
                }

                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(DateTime) || property.ClrType == typeof(DateTime?))
                    {
                        property.SetValueConverter(utcConverter);
                    }
                }
            }
        }


    }
}