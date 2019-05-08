namespace Domain.Dominio.Modelo
{
    public class Estado : DominioAbstract
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Guid Pais_Ukey { get; set; }
        public ICollection<Cidade> Cidades { get; set; }
    }
}
