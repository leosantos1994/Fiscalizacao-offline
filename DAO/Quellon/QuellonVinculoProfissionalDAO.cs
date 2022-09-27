using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;

namespace Fiscalizacao.Quellon
{
    public class QuellonVinculoProfissionalDAO
    {
        QuellonConfig config;
        public QuellonVinculoProfissionalDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<VinculoProfissionalModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("VinculoProfissionalXml"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesVinculoProfissional());
                AdicionarCamposJoinVinculoProfissional(xml);
                xml.addFilterColumnSelect("Pessoa", XMLMaker.EstaEm, pessoas, XMLMaker.E);
                xml.addFilterColumnSelect("PessoaJuridica", XMLMaker.EstaEm, pessoas, XMLMaker.Or);

                return xml.XmlModelReaderBySelectColumns<VinculoProfissionalModel>();
            }
        }

        private string ColunasSimplesVinculoProfissional()
        {
            return "PeriodoInicial, PeriodoFinal, DataRegistroNova,DataValidadeCRT, HoraInicioTurno, " +
                   "HoraFimTurno, NumeroART, Livro,Folha, Observacoes,CargaHorariaSemanal, " +
                   "ResponsavelTecnico, Gestao ";
        }

        private void AdicionarCamposJoinVinculoProfissional(IXMLMaker xml)
        {
            xml.addColumnSelect("Pessoa", "PessoaId");
            xml.addColumnSelect("PessoaJuridica", "PessoaJuridicaId");
            xml.addColumnSelect("TipoSetorAtuacao.Descricao", "TipoSetorAtuacao");
            xml.addColumnSelect("Atividade.Descricao", "Atividade");
            xml.addColumnSelect("TipoConcessao.Descricao", "TipoConcessao");
            xml.addColumnSelect("Situacao", "Situacao");
            xml.addColumnSelect("Turno.Descricao", "Turno");
            xml.addColumnSelect("TipoART.Descricao", "TipoART");
            xml.addColumnSelect("Tipo", "VinculoProfissionalTipo");

        }
    }
}