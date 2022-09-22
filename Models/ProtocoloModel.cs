using System;
namespace Fiscalizacao.Models
{
    public class ProtocoloModel : ModelBase
    {
        public int? PessoaId { get; set; }
        public int? PessoaJuridicaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
        public virtual PessoaModel PessoaJuridica { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoAssunto { get; set; }
        public bool TaxasLiquidadas { get; set; }
        public bool Concluido { get; set; }
        public bool Autuado { get; set; }
        public DateTime? DataDocumento { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string TipoPedido { get; set; }
        public DateTime? DataProtocolo { get; set; }
        public string Protocolo { get; set; }
        public string Observacao { get; set; }
        public string DepartamentoOrigem { get; set; }
        public string ColaboradorOrigem { get; set; }
        public string DepartamentoDestino { get; set; }
        public string ColaboradorDestino { get; set; }
    }
}
