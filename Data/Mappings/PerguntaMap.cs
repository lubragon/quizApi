
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApi.Dominio.Entities;

namespace QuizApi.Data.Mappings
{
    public class PerguntaMap : IEntityTypeConfiguration<Pergunta>
    {
        public void Configure(EntityTypeBuilder<Pergunta> builder)
        {
            builder.ToTable("Pergunta");

            builder.HasKey(p => p.Id);

            builder.Property(p =>p.Texto)
                .IsUnicode(true)
                .HasMaxLength(100);

            builder.HasOne(p => p.Quiz)
                .WithMany(q => q.Perguntas);
        }
    }
}

