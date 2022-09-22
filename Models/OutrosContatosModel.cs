namespace Fiscalizacao.Models
{
    public class OutrosContatosModel : ModelBase
    {
        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
        public TipoContato TipoContato { get; set; }
        public string Contato { get; set; }
        public string Complemento { get; set; }
        public string Ramal { get; set; }
        public bool Comunicar { get; set; }
    }
}