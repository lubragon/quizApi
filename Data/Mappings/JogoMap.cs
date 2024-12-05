
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

            builder.HasOne(j => j.Quiz)
                .WithOne(q => q.Jogo)
                .HasForeignKey<Quiz>(q => q.Id)
                .IsRequired();

        }

    }

}