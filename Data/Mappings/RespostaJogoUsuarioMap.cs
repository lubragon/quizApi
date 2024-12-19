using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Elevate.QuizApi.Dominio.Entities;

namespace Elevate.QuizApi.Data.Mappings
{

    public class RespostaJogoUsuarioMap :IEntityTypeConfiguration<RespostaJogoUsuario>
    {
        public void Configure(EntityTypeBuilder<RespostaJogoUsuario> builder)
        {
            builder.ToTable("RespostaJogoUsuario");

            builder.HasKey(rj => rj.Id);
 
            builder.HasOne(rj => rj.Resposta)
                .WithMany()
                .HasForeignKey(rj => rj.IdResposta);

            builder.HasOne(rj => rj.JogoUsuario)
                .WithMany()
                .HasForeignKey(rj => rj.IdJogoUsuario);
        }
    }



}