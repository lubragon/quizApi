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

            builder.HasOne(j => j.Usuario)
                .WithMany()
                .HasForeignKey(j => j.IdUsuario);
 
            builder.HasMany(ju => ju.Resposta)
                .WithMany()
                .UsingEntity(j => j.ToTable("RespostaJogoUsuario"));
        }
    }



}