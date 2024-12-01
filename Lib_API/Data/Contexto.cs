using Microsoft.EntityFrameworkCore;
using Lib_API.Models;

namespace Lib_API.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Leitor> Leitores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
          modelBuilder.Entity<Autor>() .HasMany(a => a.Livros) .WithOne(l => l.Autor) .HasForeignKey(l => l.AutorId); 
            
            
            modelBuilder.Entity<Leitor>() .HasMany(le => le.Emprestimos) .WithOne(e => e.Leitor) .HasForeignKey(e => e.LeitorId);

            
            modelBuilder.Entity<Livro>().HasMany(l => l.Emprestimos).WithOne(e => e.Livro).HasForeignKey(e => e.LivroId);

            base.OnModelCreating(modelBuilder); }

        }
    }
