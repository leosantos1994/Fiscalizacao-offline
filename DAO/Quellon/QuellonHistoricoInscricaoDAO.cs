using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;

namespace Fiscalizacao.Quellon
{
    public  class QuellonHistoricoInscricaoDAO
    {
        QuellonConfig config;
        public QuellonHistoricoInscricaoDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<HistoricoInscricaoModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("HistoricoInscricaoCategoria"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesInscricao());
                AdicionarCamposJoinInscricao(xml);
                xml.addFilterColumnSelect("Pessoa", XMLMaker.EstaEm, pessoas);
                return xml.XmlModelReaderBySelectColumns<HistoricoInscricaoModel>();
            }
        }

        private string ColunasSimplesInscricao()
        {
            return "DataInscricaoOrigem,DataInicial,DataFinal,DataValidadeCarteira,DataConclusaoCurso,"+
                   "DataCF,DataProrrogacao,DataAcordao,RegistroConselho,LivroCF," +
                   "FolhaCF";
        }

        private void AdicionarCamposJoinInscricao(IXMLMaker xml)
        {
            xml.addColumnSelect("Pessoa", "PessoaId");
            xml.addColumnSelect("Especialidade.Descricao", "Especialidade");
            xml.addColumnSelect("TipoCategoria.Descricao", "TipoCategoria");
            xml.addColumnSelect("TipoInscricao.Descricao", "TipoInscricao");
            xml.addColumnSelect("Situacao.Descricao", "Situacao");
            xml.addColumnSelect("ComplementoSituacao.Descricao", "ComplementoSituacao");
            xml.addColumnSelect("MotivoSituacao.Descricao", "MotivoSituacao");
        }
    }
}