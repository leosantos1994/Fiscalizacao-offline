using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;
using System.Linq;

namespace Fiscalizacao.Quellon
{
    public class QuellonProcessoTramiteFiscalizacaoDAO
    {
        QuellonConfig config;
        public QuellonProcessoTramiteFiscalizacaoDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<ProcessoTramiteFiscalizacaoModel> Buscar(string processos)
        {
            var tramites = new List<ProcessoTramiteFiscalizacaoModel>();

            var tramitesTedAdm = BuscarTEDADM(processos);
            tramites.AddRange(tramitesTedAdm);

            return tramites.AsEnumerable();
        }

        private IEnumerable<ProcessoTramiteFiscalizacaoModel> BuscarTEDADM(string processos)
        {
            using (IXMLMaker xml = config.Consulta("ProcessoTramiteFis"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesTEDADM());
                AdicionarCamposJoinTEDADM(xml);
                xml.addFilterColumnSelect("Processo", XMLMaker.EstaEm, processos);
                return xml.XmlModelReaderBySelectColumns<ProcessoTramiteFiscalizacaoModel>();
            }
        }
        private string ColunasSimplesTEDADM()
        {
            return "Data,DataFim,AbriuPrazoEm,PrazoFinal,Observacao ";
        }

        private void AdicionarCamposJoinTEDADM(IXMLMaker xml)
        {
            xml.addColumnSelect("ProcessoTipoMovimento.Descricao", "ProcessoTipoMovimento");
            xml.addColumnSelect("ProcessoFase.Descricao", "ProcessoFase");
            xml.addColumnSelect("ProcessoInstancia.Nome", "ProcessoInstancia");
            xml.addColumnSelect("Situacao.Descricao", "Situacao");
            xml.addColumnSelect("Relator.Relator.Nome", "Relator");
            xml.addColumnSelect("TramiteEncerraPrazo.Descricao", "TramiteEncerraPrazo");
            xml.addColumnSelect("Processo", "ProcessoId");
            xml.addColumnSelect("NumeroProcesso", "NumeroProcessoFiscaliza");
        }
    }
}