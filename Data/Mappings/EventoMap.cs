
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Elevate.QuizApi.Data.Mappings;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Data.Mappings
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("Evento");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Titulo)
                .IsUnicode()
                .HasMaxLength(50);
            builder.Property(e => e.Descricao)
                .IsUnicode()
                .HasMaxLength(500);


        }
    }
}

