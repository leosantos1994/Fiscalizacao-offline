using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;

namespace Fiscalizacao.Quellon
{
    public class QuellonProtocoloDAO
    {
        QuellonConfig config;
        public QuellonProtocoloDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<ProtocoloModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("ProtocoloDocumento"))
            {
                ColunasSimplesProtocolo(xml);
                AdicionarCamposJoinProtocolo(xml);
                xml.addFilterColumnSelect("Remetente", XMLMaker.EstaEm, pessoas, XMLMaker.E);
                xml.addFilterColumnSelect("Sociedade", XMLMaker.EstaEm, pessoas, XMLMaker.Or);
                return xml.XmlModelReaderBySelectColumns<ProtocoloModel>();
            }
        }

        private void ColunasSimplesProtocolo(IXMLMaker xml)
        {
            xml.addColumnSelect("NumeroDocumento");
            xml.addColumnSelect("TaxasLiquidadas");
            xml.addColumnSelect("Concluido");
            xml.addColumnSelect("Autuado");
            xml.addColumnSelect("DataDocumento");
            xml.addColumnSelect("DataCadastro");
            xml.addColumnSelect("DataProtocolo");
            xml.addColumnSelect("Observacao");
        }

        private void AdicionarCamposJoinProtocolo(IXMLMaker xml)
        {
            xml.addColumnSelect("Remetente", "PessoaId");
            xml.addColumnSelect("Sociedade", "SociedadeId");
            xml.addColumnSelect("TipoAssunto.Descricao", "TipoAssunto");
            xml.addColumnSelect("TipoPedido.Descricao", "TipoProcesso");
            xml.addColumnSelect("Protocolo.NumeroProtocolo", "Protocolo");
            xml.addColumnSelect("DepartamentoOrigem.Descricao", "DepartamentoOrigem");
            xml.addColumnSelect("DepartamentoDestino.Descricao", "DepartamentoDestino");
            xml.addColumnSelect("ColaboradorOrigem.Nome", "ColaboradorOrigem");
            xml.addColumnSelect("ColaboradorDestino.Nome", "ColaboradorDestino");
        }
    }
}