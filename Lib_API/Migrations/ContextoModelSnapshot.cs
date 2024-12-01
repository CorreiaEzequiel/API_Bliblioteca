﻿// <auto-generated />
using System;
using Lib_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lib_API.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lib_API.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DtNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Lib_API.Models.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DiariaLivro")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LeitorId")
                        .HasColumnType("int");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeitorId");

                    b.HasIndex("LivroId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("Lib_API.Models.Leitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DtNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leitores");
                });

            modelBuilder.Entity("Lib_API.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AnoLancamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Paginas")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Lib_API.Models.Emprestimo", b =>
                {
                    b.HasOne("Lib_API.Models.Leitor", "Leitor")
                        .WithMany("Emprestimos")
                        .HasForeignKey("LeitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib_API.Models.Livro", "Livro")
                        .WithMany("Emprestimos")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Leitor");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Lib_API.Models.Livro", b =>
                {
                    b.HasOne("Lib_API.Models.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Lib_API.Models.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("Lib_API.Models.Leitor", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("Lib_API.Models.Livro", b =>
                {
                    b.Navigation("Emprestimos");
                });
#pragma warning restore 612, 618
        }
    }
}
