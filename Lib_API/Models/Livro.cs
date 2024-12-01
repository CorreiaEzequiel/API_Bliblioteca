namespace Lib_API.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int Paginas { get; set; }
        public DateTime AnoLancamento { get; set; }
        public string Genero { get; set; }
        public bool Disponivel { get; set; } = true;

        public ICollection<Emprestimo> Emprestimos { get; set; }

    }
}
