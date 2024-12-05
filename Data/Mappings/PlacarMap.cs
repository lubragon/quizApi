
// using System.Reflection.Metadata;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using QuizApi.Dominio.Entities;

// namespace QuizApi.Data.Mappings
// {
//     public class PlacarMap : IEntityTypeConfiguration<Placar>
//     {
//         public void Configure(EntityTypeBuilder<Placar> builder)
//         {
//             builder.ToTable("Placar");

//             builder.HasKey(p => p.Id);

//             builder.Property(p => p.Pontuacao).HasColumnName("Pontuação");;
//             // Pontuacao = Quantidade de respostas corretas por usuário

     

//             builder.HasOne(p => p.Quiz)
//                 .WithMany()

//         }
//     }
// }

