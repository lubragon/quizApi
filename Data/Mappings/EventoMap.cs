
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizApi.Dominio.Entities;

namespace QuizApi.Data.Mappings
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

