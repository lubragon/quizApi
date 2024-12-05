
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApi.Dominio.Entities;

namespace QuizApi.Data.Mappings
{
    public class QuizMap : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Quiz");

            builder.HasKey(q => q.Id);

            builder.Property(q => q.Tipo)
                .HasMaxLength(50);
            //builder.Property(q => q.ImagemCaminho).IsUnicode(true);
            // TODO IMAGEM


            // TODO DELETAR HAS FOREGIN KEY
            // DELETAR COLUM NAMES

            builder.HasOne(q => q.Evento)
                .WithMany(e => e.Quizzes);
        }
    }
}

