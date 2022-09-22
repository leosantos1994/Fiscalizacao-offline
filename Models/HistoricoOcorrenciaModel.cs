using System;


namespace Fiscalizacao.Models
{
    public class HistoricoOcorrenciaModel : ModelBase
    {
        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataFim { get; set; }
        public string Classificacao { get; set; }
        public string OcorrenciaDetalhe { get; set; }
        public string InscricaoCategoria { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
    }
}
