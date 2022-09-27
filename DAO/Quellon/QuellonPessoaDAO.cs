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
    public class QuellonPessoaDAO
    {
        QuellonConfig config;
        public QuellonPessoaDAO(QuellonConfig config)
        {
            this.config = config;
        }

        #region Private
        public IEnumerable<PessoaModel> BuscarInformacoesPessoas(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("PessoaXml"))
            {
                xml.MaxPages = 100;
                xml.addColumnDesc("ID");

                if (!string.IsNullOrEmpty(pessoas))
                    xml.addFilterColumnSelect("ID", XMLMaker.EstaEm, pessoas);

                ColunasSimplesPessoa(xml);
                AdicionarCamposJoinPessoa(xml);
                return xml.XmlModelReaderBySelectColumns<PessoaModel>();
            }
        }

        private void ColunasSimplesPessoa(IXMLMaker xml)
        {
            xml.addColumnSelect("DataNascimentoFundacao");
            xml.addColumnSelect("Nome");
            xml.addColumnSelect("CPFCNPJ");
            xml.addColumnSelect("NumeroProcesso");
            xml.addColumnSelect("NumeroProcessoAntigo");
            xml.addColumnSelect("NomeAbreviado");
            xml.addColumnSelect("NomeSocial");
            xml.addColumnSelect("RegistroConselho");
            xml.addColumnSelect("LogradouroResidencial");
            xml.addColumnSelect("ComplementoResidencial");
            xml.addColumnSelect("NumeroResidencial");
            xml.addColumnSelect("BairroResidencial");
            xml.addColumnSelect("TelefoneResidencial");
            xml.addColumnSelect("TelefoneCelular");
            xml.addColumnSelect("EmailResidencial");
            xml.addColumnSelect("LogradouroComercial");
            xml.addColumnSelect("ComplementoComercial");
            xml.addColumnSelect("NumeroComercial");
            xml.addColumnSelect("BairroComercial");
            xml.addColumnSelect("TelefoneComercial");
            xml.addColumnSelect("EmailComercial");
            xml.addColumnSelect("CorrespondenciaResidencial");
            xml.addColumnSelect("CorrespondenciaComercial");
            xml.addColumnSelect("DataValidadeInscricao");
            xml.addColumnSelect("Inadimplente");
            xml.addColumnSelect("RG");
            xml.addColumnSelect("TipoPessoa");

        }

        private void AdicionarCamposJoinPessoa(IXMLMaker xml)
        {
            xml.addColumnSelect("ID", "IdConselho");
            xml.addColumnSelect("CEPResidencial.CEP", "CEPResidencial");
            xml.addColumnSelect("EstadoResidencial.Sigla", "EstadoResidencial");
            xml.addColumnSelect("MunicipioResidencial.Descricao", "MunicipioResidencial");
            xml.addColumnSelect("CEPComercial.CEP", "CEPComercial");
            xml.addColumnSelect("MunicipioComercial.Descricao", "MunicipioComercial");
            xml.addColumnSelect("EstadoComercial.Sigla", "EstadoComercial");
            xml.addColumnSelect("SituacaoAtual.Descricao", "StuacaoAtual");
            xml.addColumnSelect("ComplementoSituacao.Descricao", "ComplementoSituacao");
            xml.addColumnSelect("MotivoSituacaoAtual.Descricao", "MotivoSituacao");
            xml.addColumnSelect("SubUnidadeAtual.NomeSubUnidade", "SubUnidadeAtual");
        }
        #endregion
    }
}
