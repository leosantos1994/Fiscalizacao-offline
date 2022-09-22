using System;

namespace Fiscalizacao.Models
{
    public class ProcessoTramiteFiscalizacaoModel : ModelBase
    {
        public int ProcessoId { get; set; }
        public virtual ProcessoFiscalizacaoModel Processo { get; set; }

        public string NumeroProcessoFiscaliza { get; set; }
        public string ProcessoTipoMovimento { get; set; }
        public string ProcessoFase { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataFinal { get; set; }
        public string ProcessoInstancia { get; set; }
        public DateTime DataSessao { get; set; }
        public string Situacao { get; set; }
        public string Sessao { get; set; }
        public string NumeroSessao { get; set; }
        public string Relator { get; set; }
        public string AbriuPrazoEm { get; set; }
        public string PrazoFinal { get; set; }
        public string TramiteEncerraPrazo { get; set; }
        public string Observacao { get; set; }
    }
}
