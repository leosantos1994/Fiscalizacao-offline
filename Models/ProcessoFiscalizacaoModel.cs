
using System;
using System.Collections.Generic;

namespace Fiscalizacao.Models
{
    public class ProcessoFiscalizacaoModel : ModelBase
    {
        public int? RepresentanteId { get; set; }
        public int? RepresentadoId { get; set; }
        public virtual PessoaModel Representante { get; set; }
        public virtual PessoaModel Representado { get; set; }
        public virtual ICollection<ProcessoTramiteFiscalizacaoModel> ProcessoTramite { get; set; }

        public string NumeroProcesso { get; set; }
        public string AnoProcesso { get; set; }
        public string ProtocoloDocumento { get; set; }
        public string TipoProcesso { get; set; }
        public string TramiteAtual { get; set; }
        public string NumeroProcessoDestino { get; set; }
        public string ProcessoFase { get; set; }
        public string Situacao { get; set; }
        public string Instancia { get; set; }
        public string Relator { get; set; }
        public string TipoDesignacao { get; set; }
        public string MembroDesignado { get; set; }
        public string SubUnidade { get; set; }
        public string ProcessoTipoDecisao { get; set; }
        public string ComplementoDecisao { get; set; }
        public string DecisaoUnanime { get; set; }
        public string DataDecisao { get; set; }
        public string PessoaFiscal { get; set; }
        public string DescricaoFatos { get; set; }
        public string Observacao2 { get; set; }
        public string Observacao { get; set; }

        public DateTime DataProcesso { get; set; }
        public DateTime DataValidade { get; set; }
        public string Orientacoes { get; set; }
        public ModuloProcesso Modulo { get; set; }
    }
}
