﻿// <auto-generated />
using System;
using Elevate.QuizApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QuizApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241223165614_PontuacaoFinalColunaJogoUsuario")]
    partial class PontuacaoFinalColunaJogoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdQuiz")
                        .HasColumnType("int");

                    b.Property<bool>("IsJogoIniciado")
                        .HasColumnType("bit");

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataJogo")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdJogo")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("JogadorAvulso")
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("PontuacaoFinal")
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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdQuiz")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdQuiz");

                    b.ToTable("Pergunta", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEvento")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadePerguntaPorQuiz")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TempoTotalQuiz")
                        .HasColumnType("time");

                    b.Property<int?>("Tipo")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Quiz", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Resposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPergunta")
                        .HasColumnType("int");

                    b.Property<bool>("IsCorreta")
                        .HasColumnType("bit")
                        .HasColumnName("Gabarito");

                    b.Property<int?>("JogoUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("IdPergunta");

                    b.HasIndex("JogoUsuarioId");

                    b.ToTable("Respostas", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.RespostaJogoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdJogoUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdResposta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdJogoUsuario");

                    b.HasIndex("IdResposta");

                    b.ToTable("RespostaJogoUsuario", (string)null);
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tipo")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
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
                        .HasForeignKey("IdUsuario");

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

                    b.HasOne("Elevate.QuizApi.Dominio.Entities.JogoUsuario", null)
                        .WithMany("Resposta")
                        .HasForeignKey("JogoUsuarioId");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.RespostaJogoUsuario", b =>
                {
                    b.HasOne("Elevate.QuizApi.Dominio.Entities.JogoUsuario", "JogoUsuario")
                        .WithMany()
                        .HasForeignKey("IdJogoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elevate.QuizApi.Dominio.Entities.Resposta", "Resposta")
                        .WithMany()
                        .HasForeignKey("IdResposta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JogoUsuario");

                    b.Navigation("Resposta");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.Jogo", b =>
                {
                    b.Navigation("JogoUsuarios");
                });

            modelBuilder.Entity("Elevate.QuizApi.Dominio.Entities.JogoUsuario", b =>
                {
                    b.Navigation("Resposta");
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
