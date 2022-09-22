using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;
using System.Linq;

namespace Fiscalizacao.Quellon
{
    public class QuellonProcessosDAO
    {
        QuellonConfig config;
        public QuellonProcessosDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<ProcessoModel> Buscar(string pessoas)
        {
            var list = new List<ProcessoModel>();
            var processosADM = BuscarTEDADM(1, pessoas).ToList();
            processosADM.ForEach(processo => processo.Modulo = ModuloProcesso.Secretaria);

            var processosTED = BuscarTEDADM(2, pessoas).ToList();
            processosTED.ForEach(processo => processo.Modulo = ModuloProcesso.TED);
            
            list.AddRange(processosADM);
            list.AddRange(processosTED);

            return list.AsEnumerable();
        }

        #region TED ADM
        private IEnumerable<ProcessoModel> BuscarTEDADM(int modulo, string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("ProcessoXML"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesTEDADM());
                AdicionarCamposJoinTEDADM(xml);
                xml.addFilterColumnSelect("Modulo", XMLMaker.Igual, modulo);
                xml.addFilterColumnSelect("Representado", XMLMaker.EstaEm, pessoas, XMLMaker.E);
                xml.addFilterColumnSelect("Representante", XMLMaker.EstaEm, pessoas, XMLMaker.Or);
                return xml.XmlModelReaderBySelectColumns<ProcessoModel>();
            }
        }

        private string ColunasSimplesTEDADM()
        {
            return "DecisaoUnanime, DataDecisao, AnoProcesso, NumeroProcessoDestino, DescricaoFatos," + "Observacao2, Observacao";
        }

        private void AdicionarCamposJoinTEDADM(IXMLMaker xml)
        {
            xml.addColumnSelect("ProtocoloDocumento.Protocolo.NumeroProtocolo", "ProtocoloDocumento");
            xml.addColumnSelect("TipoProcesso.Descricao", "TipoProcesso");
            xml.addColumnSelect("TramiteAtual.ProcessoTipoMovimento.Descricao", "TramiteAtual");
            xml.addColumnSelect("Representado", "RepresentadoId");
            xml.addColumnSelect("Representante", "RepresentanteId");
            xml.addColumnSelect("ProcessoFase.Descricao", "ProcessoFase");
            xml.addColumnSelect("Situacao.Descricao", "Situacao");
            xml.addColumnSelect("Instancia.Nome", "Instancia");
            xml.addColumnSelect("Relator.Relator.Nome", "Relator");
            xml.addColumnSelect("TipoDesignacao.Descricao", "TipoDesignacao");
            xml.addColumnSelect("MembroDesignado.Pessoa.Nome", "MembroDesignado");
            xml.addColumnSelect("SubUnidade.NomeSubUnidade", "SubUnidade");
            xml.addColumnSelect("ProcessoTipoDecisao.Descricao", "ProcessoTipoDecisao");
            xml.addColumnSelect("ComplementoDecisao.Descricao", "ComplementoDecisao");
            xml.addColumnSelect("PessoaFiscal.Nome", "PessoaFiscal");
            xml.addColumnSelect("NumeroProcessoFiscaliza", "NumeroProcesso");
        }
        #endregion
    }
}