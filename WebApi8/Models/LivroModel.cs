namespace WebApi8.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; } // Foreing key 1:N
    }
}
