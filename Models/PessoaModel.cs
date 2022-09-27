using System;
using System.Collections.Generic;

namespace Fiscalizacao.Models
{
    public class PessoaModel : ModelBase
    {
        public virtual ICollection<FinanceiroModel> Financeiro { get; set; }
        public virtual ICollection<ProtocoloModel> Protocolo { get; set; }
        public virtual ICollection<ProtocoloModel> ProtocoloPJ { get; set; }
        public virtual ICollection<VinculoProfissionalModel> VinculoProfissional { get; set; }
        public virtual ICollection<VinculoProfissionalModel> VinculoProfissionalPJ { get; set; }
        public virtual ICollection<OutrosContatosModel> OutrosContatos { get; set; }
        public virtual ICollection<HistoricoInscricaoModel> Inscricao { get; set; }
        public virtual ICollection<HistoricoOcorrenciaModel> Ocorrencia { get; set; }
        public virtual ICollection<FormacaoAcademicaModel> Formacao { get; set; }
        public virtual ICollection<ProcessoModel> ProcessoRepresentado { get; set; }
        public virtual ICollection<ProcessoModel> ProcessoRepresentante { get; set; }
        public virtual ICollection<ProcessoFiscalizacaoModel> ProcessoRepresentadoFiscalizacao { get; set; }
        public virtual ICollection<ProcessoFiscalizacaoModel> ProcessoRepresentanteFiscalizacao { get; set; }

        public bool Inadimplente { get; set; }
        public bool CorrespondenciaResidencial { get; set; }
        public bool CorrespondenciaComercial { get; set; }
        public DateTime DataNascimentoFundacao { get; set; }
        public DateTime DataValidadeInscricao { get; set; }
        public DateTime DataUltimaVisita { get; set; }
        public string Nome { get; set; }
        public string CPFCNPJ { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroProcessoAntigo { get; set; }
        public string NomeAbreviado { get; set; }
        public string NomeSocial { get; set; }
        public string RegistroConselho { get; set; }
        public string LogradouroResidencial { get; set; }
        public string ComplementoResidencial { get; set; }
        public string NumeroResidencial { get; set; }
        public string BairroResidencial { get; set; }
        public string TelefoneResidencial { get; set; }
        public string EstadoResidencial { get; set; }
        public string MunicipioResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string EmailResidencial { get; set; }
        public string ComplementoComercial { get; set; }
        public string NumeroComercial { get; set; }
        public string BairroComecial { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneCEmailComercialomercial { get; set; }
        public string CEPResidencial { get; set; }
        public string CEPComercial { get; set; }
        public string MunicipioComercial { get; set; }
        public string RG { get; set; }
        public string TipoPessoa { get; set; }
        public string EstadoComercial { get; set; }
        public string StuacaoAtual { get; set; }
        public string ComplementoSituacao { get; set; }
        public string MotivoSituacao { get; set; }
        public string SubUnidadeAtual { get; set; }
    }
}