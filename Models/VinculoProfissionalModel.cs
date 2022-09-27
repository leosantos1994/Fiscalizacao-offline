
using System;

namespace Fiscalizacao.Models
{
    public class VinculoProfissionalModel : ModelBase
    {
        public int? PessoaId { get; set; }
        public int? PessoaJuridicaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
        public virtual PessoaModel PessoaJuridica { get; set; }

        public string TipoVinculo { get; set; }

        public DateTime PeriodoInicial { get; set; }
        public DateTime PeriodoFinal { get; set; }
        public DateTime DataRegistroNova { get; set; }
        public DateTime DataValidadeCRT { get; set; }
        public DateTime HoraInicioTurno { get; set; }
        public DateTime HoraFimTurno { get; set; }
        public string NumeroART { get; set; }
        public string Livro { get; set; }
        public string Folha { get; set; }
        public string Observacoes { get; set; }
        public decimal CargaHorariaSemanal { get; set; }
        public bool ResponsavelTecnico { get; set; }
        public Gestao Gestao { get; set; }
        public Funcao Funcao { get; set; }
        public string TipoSetorAtuacao { get; set; }
        public string Atividade { get; set; }
        public string TipoConcessao { get; set; }
        public SituacaoVinculo Situacao { get; set; }
        public string Turno { get; set; }
        public string TipoART { get; set; }
        public VinculoProfissionalTipo VinculoProfissionalTipo { get; set; }
    }
}
