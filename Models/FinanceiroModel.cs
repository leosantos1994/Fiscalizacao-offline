using System;

namespace Fiscalizacao.Models
{
    public class FinanceiroModel : ModelBase
    {
        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }

        public decimal ValorBruto { get; set; }
        public decimal ValorSaldo { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal VlrCalculadoReceber { get; set; }

        public string DividaAtiva { get; set; }
        public string Ano { get; set; }
        public string Parcela { get; set; }
        public DateTime DataMovimento { get; set; }
        public DateTime DataOperacao { get; set; }
        public DateTime DataExecucao { get; set; }
        public string Situacao { get; set; }
        public string ComplementoSituacao { get; set; }
        public string TipoLancamento { get; set; }
        public string Numero { get; set; }
    }
}
