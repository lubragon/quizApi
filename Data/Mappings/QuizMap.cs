
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Data.Mappings
{
    public class QuizMap : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Quiz");

            builder.HasKey(q => q.Id);

            builder.Property(q => q.Titulo)
                .HasMaxLength(50);
            builder.Property(q => q.Tipo)
                .HasMaxLength(50);

            builder.HasMany(q => q.Perguntas)
                .WithOne()
                .HasForeignKey(p => p.IdQuiz);

            builder.HasOne(q => q.Evento)
                .WithMany()
                .HasForeignKey(q => q.IdEvento);
        }
    }
}

