
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApi.Dominio.Entities;

namespace QuizApi.Data.Mappings
{
    public class RespostasMap : IEntityTypeConfiguration<Resposta>
    {
        public void Configure(EntityTypeBuilder<Resposta> builder)
        {
            builder.ToTable("Respostas");


            builder.HasKey(r => r.Id);
            builder.Property(r => r.IsCorreta).HasColumnName("Gabarito");
            builder.Property(r => r.Texto)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(r => r.Pergunta)
                .WithMany(p => p.Respostas);
        }
    }
}

