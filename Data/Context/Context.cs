using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Elevate.QuizApi.Data.Mappings;
using Elevate.QuizApi.Dominio.Entities;
using Elevate.uizApi.Data.Mappings;

namespace Elevate.QuizApi.Data.Context
{
    public class Context : DbContext
    {
        public Context() { }

        // public Context(IConfigurationRoot config, DbContextOptions<Context> options) : base(options)
        // {

        // }

        public Context(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuizMap());
            modelBuilder.ApplyConfiguration(new PerguntaMap());
            modelBuilder.ApplyConfiguration(new RespostasMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EventoMap());


            modelBuilder.Entity<Jogo>()
                .HasOne(j => j.Quiz)
                .WithOne(q => q.Jogo)
                .HasForeignKey<Quiz>(q => q.Id)
                .IsRequired();


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