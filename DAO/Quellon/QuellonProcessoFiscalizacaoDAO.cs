using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscalizacao.Quellon
{
    public class QuellonProcessoFiscalizacaoDAO
    {
        QuellonConfig config;
        public QuellonProcessoFiscalizacaoDAO(QuellonConfig config)
        {
            this.config = config;
        }

        #region Fiscalizacao
        public IEnumerable<ProcessoFiscalizacaoModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("ProcessoFiscalizacaoXML"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesFiscalizacao());
                AdicionarCamposJoinFiscalizacao(xml);
                xml.addFilterColumnSelect("Representado", XMLMaker.EstaEm, pessoas, XMLMaker.E);
                xml.addFilterColumnSelect("PessoaJuridica", XMLMaker.EstaEm, pessoas, XMLMaker.Or);
                return xml.XmlModelReaderBySelectColumns<ProcessoFiscalizacaoModel>();
            }
        }

        private string ColunasSimplesFiscalizacao()
        {
            return "AnoProcesso,DataProcesso, NumeroProcessoDestino, DescricaoFatos, Observacao,Orientacoes";
        }

        private void AdicionarCamposJoinFiscalizacao(IXMLMaker xml)
        {
            xml.addColumnSelect("NumeroProcessoFiscaliza", "NumeroProcesso");

            xml.addColumnSelect("TipoProcesso.Descricao", "TipoProcesso");
            xml.addColumnSelect("ProtocoloDocumento.Protocolo.NumeroProtocolo", "ProtocoloDocumento");
            xml.addColumnSelect("TramiteAtual.ProcessoTipoMovimento.Descricao", "TramiteAtual");
            xml.addColumnSelect("Representado", "RepresentadoId");
            xml.addColumnSelect("PessoaJuridica", "RepresentanteId");
            xml.addColumnSelect("ProcessoFase.Descricao", "ProcessoFase");
            xml.addColumnSelect("Situacao.Descricao", "Situacao");
            xml.addColumnSelect("Instancia.Nome", "Instancia");
            xml.addColumnSelect("Relator.Relator.Nome", "Relator");
            xml.addColumnSelect("SubUnidade.NomeSubUnidade", "SubUnidade");
            xml.addColumnSelect("PessoaFiscal.Nome", "PessoaFiscal");
        }
        #endregion
    }
}
