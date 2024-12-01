namespace Lib_API.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int LeitorId { get; set; }
        public Leitor Leitor { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public decimal? DiariaLivro { get; set; }
        public decimal? valorTotal => (DataDevolucao.HasValue)? (DataDevolucao.Value - DataEmprestimo).Days * DiariaLivro : 
            (DateTime.Now - DataEmprestimo).Days * DiariaLivro;


    }
}
