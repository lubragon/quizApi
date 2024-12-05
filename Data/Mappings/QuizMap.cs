
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


            //builder.Property(q => q.ImagemCaminho).IsUnicode(true);
            // TODO IMAGEM

            builder.HasOne(q => q.Evento)
                .WithMany(e => e.Quizzes);
        }
    }
}

