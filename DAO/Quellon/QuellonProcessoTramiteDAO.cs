using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;
using System.Linq;

namespace Fiscalizacao.Quellon
{
    public class QuellonProcessoTramiteDAO
    {
        QuellonConfig config;
        public QuellonProcessoTramiteDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<ProcessoTramiteModel> Buscar(string processos)
        {
            var tramites = new List<ProcessoTramiteModel>();

            var tramitesTedAdm = BuscarTEDADM(processos);
            tramites.AddRange(tramitesTedAdm);

            return tramites.AsEnumerable();
        }

        private IEnumerable<ProcessoTramiteModel> BuscarTEDADM(string processos)
        {
            using (IXMLMaker xml = config.Consulta("ProcessoTramite"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesTEDADM());
                AdicionarCamposJoinTEDADM(xml);
                xml.addFilterColumnSelect("Processo", XMLMaker.EstaEm, processos);
                return xml.XmlModelReaderBySelectColumns<ProcessoTramiteModel>();
            }
        }
        private string ColunasSimplesTEDADM()
        {
            return "NumeroProcessoFiscaliza,Data,DataFinal,DataSessao,AbriuPrazoEm,PrazoFinal,Observacao,NumeroSessao ";
        }

        private void AdicionarCamposJoinTEDADM(IXMLMaker xml)
        {
            xml.addColumnSelect("ProcessoTipoMovimento.Descricao", "ProcessoTipoMovimento");
            xml.addColumnSelect("ProcessoFase.Descricao", "ProcessoFase");
            xml.addColumnSelect("ProcessoInstancia.Nome", "ProcessoInstancia");
            xml.addColumnSelect("Situacao.Descricao", "Situacao");
            xml.addColumnSelect("Sessao.Numero", "Sessao");
            xml.addColumnSelect("Relator.Relator.Nome", "Relator");
            xml.addColumnSelect("TramiteEncerraPrazo.Descricao", "TramiteEncerraPrazo");
            xml.addColumnSelect("Processo", "ProcessoId");
        }
    }
}