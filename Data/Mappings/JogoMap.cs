
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Elevate.QuizApi.Dominio.Entities;


namespace Elevate.QuizApi.Data.Mappings
{

    public class JogoMap : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.ToTable("Jogo");

            builder.HasKey(j => j.Id);

            builder.HasMany(j => j.JogoUsuarios)
                .WithOne()
                .HasForeignKey(j => j.idJogo);

        }

    }

}