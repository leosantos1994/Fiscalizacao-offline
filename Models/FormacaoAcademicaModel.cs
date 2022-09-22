using System;
namespace Fiscalizacao.Models
{
    public class FormacaoAcademicaModel : ModelBase
    {
        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
        public string NomeCurso { get; set; } 
        public DateTime DataColacaoGrau { get; set; } 
        public DateTime DataRegistro { get; set; } 
        public string NumeroCurso { get; set; }
        public bool FormacaoPrincipal { get; set; }
        public bool DiplomaEntregue { get; set; }
        public string TipoDocumentoHabilitacao { get; set; }
        public string Especialidade { get; set; } 
        public string Curso { get; set; } 
        public string InstituicaoEnsino { get; set; } 
        public string InstituicaoCertificadora { get; set; } 
        public string Formacao { get; set; }
    }
}