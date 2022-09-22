using System;
using System.Collections.Generic;

namespace Fiscalizacao.Models
{
    public class HistoricoInscricaoModel: ModelBase
    {
        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
        public DateTime DataInscricaoOrigem { get; set; } 
        public DateTime DataInicial { get; set; } 
        public DateTime DataFinal { get; set; } 
        public DateTime DataValidadeCarteira { get; set; } 
        public DateTime DataConclusaoCurso { get; set; } 
        public DateTime DataCF { get; set; } 
        public DateTime DataProrrogacao { get; set; }
        public DateTime DataAcordao { get; set; } 
        public string RegistroConselho { get; set; }
        public string LivroCF { get; set; }
        public string FolhaCF { get; set; }
        public string Especialidade { get; set; } 
        public string TipoCategoria { get; set; } 
        public string TipoInscricao { get; set; } 
        public string Situacao { get; set; } 
        public string ComplementoSituacao { get; set; } 
        public string MotivoSituacao { get; set; } 
    }
}
