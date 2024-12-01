namespace Lib_API.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public ICollection<Livro> Livros { get; set; }
         
    }
}
