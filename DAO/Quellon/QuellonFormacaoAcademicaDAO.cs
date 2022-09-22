using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;

namespace Fiscalizacao.Quellon
{
    public class QuellonFormacaoAcademicaDAO
    {
        QuellonConfig config;
        public QuellonFormacaoAcademicaDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<FormacaoAcademicaModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("FormacaoAcademicaXML"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesFormacao());
                AdicionarCamposJoinFormacao(xml);
                xml.addFilterColumnSelect("Pessoa", XMLMaker.EstaEm, pessoas);                
                return xml.XmlModelReaderBySelectColumns<FormacaoAcademicaModel>();
            }
        }

        private string ColunasSimplesFormacao()
        {
            return "NomeCurso,DataColacaoGrau,DataRegistro,NumeroCurso,FormacaoPrincipal,DiplomaEntregue";
        }

        private void AdicionarCamposJoinFormacao(IXMLMaker xml)
        {
            xml.addColumnSelect("Pessoa", "PessoaId");
            xml.addColumnSelect("Formacao.Descricao", "Formacao");
            xml.addColumnSelect("InstituicaoCertificadora.Descricao", "InstituicaoCertificadora");
            xml.addColumnSelect("Especialidade.Descricao", "Especialidade");
            xml.addColumnSelect("InstituicaoEnsino.Descricao", "InstituicaoEnsino");
            xml.addColumnSelect("Curso.Curso.Descricao", "Curso");
            xml.addColumnSelect("TipoDocumentoHabilitacao.Descricao", "TipoDocumentoHabilitacao");
        }
    }
}