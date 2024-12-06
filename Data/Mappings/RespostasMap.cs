
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Data.Mappings
{
    public class RespostasMap : IEntityTypeConfiguration<Resposta>
    {
        public void Configure(EntityTypeBuilder<Resposta> builder)
        {
            builder.ToTable("Respostas");


            builder.HasKey(r => r.Id);
            builder.Property(r => r.IsCorreta)
                .HasColumnName("Gabarito");
            builder.Property(r => r.Texto)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}

