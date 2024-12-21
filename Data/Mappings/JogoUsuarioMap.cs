using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Data.Mappings
{

    public class JogoUsuarioMap :IEntityTypeConfiguration<JogoUsuario>
    {
        public void Configure(EntityTypeBuilder<JogoUsuario> builder)
        {
            builder.ToTable("JogoUsuario");

            builder.HasKey(j => j.Id);

            builder.Property(j =>j.JogadorAvulso)
                .IsUnicode(true)
                .HasMaxLength(20);

            builder.HasOne(j => j.Usuario)
                .WithMany()
                .HasForeignKey(j => j.IdUsuario);
                
            builder.HasOne(j => j.Jogo)
                .WithMany(ju => ju.JogoUsuarios)
                .HasForeignKey(j => j.IdJogo);
        }
    }



}