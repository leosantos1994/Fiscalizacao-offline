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
    public class QuellonFinanceiroDAO
    {
        QuellonConfig config;
        public QuellonFinanceiroDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<FinanceiroModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("ContaReceberXml"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesContaReceber());
                AdicionarCamposJoinContaReceber(xml);
                xml.addFilterColumnSelect("Pessoa", XMLMaker.EstaEm, pessoas);
                xml.addFilterColumnSelect("Situacao.Situacao", XMLMaker.Igual, 1);//1 = aberto/receber
                return xml.XmlModelReaderBySelectColumns<FinanceiroModel>();
            }
        }

        private string ColunasSimplesContaReceber()
        {
            return "ValorBruto, ValorSaldo, ValorSaldo, ValorLiquido, VlrCalculadoReceber," +
                   " Ano, Parcela, DataMovimento, DataOperacao, DataExecucao,Numero";
        }

        private void AdicionarCamposJoinContaReceber(IXMLMaker xml)
        {
            xml.addColumnSelect("Pessoa", "PessoaId");
            xml.addColumnSelect("Situacao.Descricao", "Situacao");
            xml.addColumnSelect("ComplementoSituacao.Descricao", "ComplementoSituacao");
            xml.addColumnSelect("TipoLancamento.Descricao", "TipoLancamento"); 
            xml.addColumnSelect("ProcessoJuridico.NumeroProcesso", "DividaAtiva"); 
        }
    }
}
