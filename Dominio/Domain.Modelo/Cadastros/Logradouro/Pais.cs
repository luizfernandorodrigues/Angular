namespace Domain.Dominio.Modelo
{
    public class Pais : DominioAbstract
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Observacoes { get; set; }
        public ICollection<Estado> Estados { get; set; }
    }
}
