﻿// <auto-generated />
using System;
using Elevate.QuizApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QuizApi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdQuiz")
                        .HasColumnType("int");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.JogoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataJogo")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdJogo")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdJogo");

                    b.HasIndex("IdUsuario");

                    b.ToTable("JogoUsuario", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Pergunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdQuiz")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdQuiz");

                    b.ToTable("Pergunta", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEvento")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadePerguntaPorQuiz")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TempoTotalQuiz")
                        .HasColumnType("time(6)");

                    b.Property<int>("Tipo")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Quiz", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Resposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPergunta")
                        .HasColumnType("int");

                    b.Property<bool>("IsCorreta")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Gabarito");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("IdPergunta");

                    b.ToTable("Respostas", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Tipo")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("JogoUsuarioResposta", b =>
                {
                    b.Property<int>("JogoUsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("RespostaId")
                        .HasColumnType("int");

                    b.HasKey("JogoUsuarioId", "RespostaId");

                    b.HasIndex("RespostaId");

                    b.ToTable("RespostaJogoUsuario", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Jogo", b =>
                {
                    b.HasOne("Elevate.QuizApi.Dominio.Entities.Quiz", "Quiz")
                        .WithMany("Jogo")
                        .HasForeignKey("QuizId");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.JogoUsuario", b =>
                {
                    b.HasOne("Elevate.QuizApi.Dominio.Entities.Jogo", "Jogo")
                        .WithMany("JogoUsuarios")
                        .HasForeignKey("IdJogo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elevate.QuizApi.Dominio.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Pergunta", b =>
                {
                    b.HasOne("Elevate.QuizApi.Dominio.Entities.Quiz", null)
                        .WithMany("Perguntas")
                        .HasForeignKey("IdQuiz")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Resposta", b =>
                {
                    b.HasOne("Elevate.QuizApi.Dominio.Entities.Pergunta", null)
                        .WithMany("Respostas")
                        .HasForeignKey("IdPergunta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JogoUsuarioResposta", b =>
                {
                    b.HasOne("Elevate.QuizApi.Dominio.Entities.JogoUsuario", null)
                        .WithMany()
                        .HasForeignKey("JogoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elevate.QuizApi.Dominio.Entities.Resposta", null)
                        .WithMany()
                        .HasForeignKey("RespostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Jogo", b =>
                {
                    b.Navigation("JogoUsuarios");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Pergunta", b =>
                {
                    b.Navigation("Respostas");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Quiz", b =>
                {
                    b.Navigation("Jogo");

                    b.Navigation("Perguntas");
                });
#pragma warning restore 612, 618
        }
    }
}
