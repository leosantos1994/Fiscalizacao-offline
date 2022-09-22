using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;

namespace Fiscalizacao.Quellon
{
    public class QuellonHistoricoOcorrenciaDAO
    {
        QuellonConfig config;
        public QuellonHistoricoOcorrenciaDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<HistoricoOcorrenciaModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("HistoricoOcorrencia"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesOcorrencia());
                AdicionarCamposJoinOcorrencia(xml);
                xml.addFilterColumnSelect("Pessoa", XMLMaker.EstaEm, pessoas);
                return xml.XmlModelReaderBySelectColumns<HistoricoOcorrenciaModel>();
            }
        }

        private string ColunasSimplesOcorrencia()
        {
            return "Data,DataFim,OcorrenciaDetalhe, Descricao, Observacao  ";
        }

        private void AdicionarCamposJoinOcorrencia(IXMLMaker xml)
        {
            xml.addColumnSelect("Pessoa", "PessoaId");
            xml.addColumnSelect("Classificacao.Descricao", "Classificacao");
            xml.addColumnSelect("InscricaoCategoria.TipoInscricao.Descricao", "InscricaoCategoria");
            xml.addColumnSelect("Categoria.Descricao", "Categoria");
        }
    }
}
