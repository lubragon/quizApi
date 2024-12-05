
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
            builder.Property(u => u.HashSenha)
                .IsUnicode(true)
                .HasMaxLength(100);

            // Relacionamentos


            // builder.HasMany(u => u.Quizzes)
            //     .WithMany(p => p.Usuario)
            //     .UsingEntity(j => j.ToTable("PlacarUsuario"));

            builder.HasOne(u => u.Jogo)
                .WithMany(j => j.Usuario);



            // TODO - Verificar relacionamentos de Usuario, n tem mais REspostaUsuario
            builder.HasMany(u => u.Respostas)
                .WithMany(r => r.Usuario)
                .UsingEntity(j => j.ToTable("RespostaUsuario"));

            
        }
    }
}

