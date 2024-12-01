namespace Lib_API.Models
{
    public class Leitor
    {
        public int Id { get; set; } 
        public string Nome {  get; set; }
        public DateTime DtNasc { get; set; }
        public string CPF { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
