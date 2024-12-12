
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsUnicode(true)
                .HasMaxLength(50);
            builder.Property(u => u.Email)
                .IsUnicode(true)
                .HasMaxLength(50);
            
            builder.Property(u => u.Tipo)
                .HasMaxLength(1);
        }
    }
}

