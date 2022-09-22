using Fiscalizacao.Models;
using HBSIS.Core.Quellon.DAO;
using Quellon.Utility;
using System.Collections.Generic;

namespace Fiscalizacao.Quellon
{
    public class QuellonOutrosContatosDAO
    {
        QuellonConfig config;
        public QuellonOutrosContatosDAO(QuellonConfig config)
        {
            this.config = config;
        }

        public IEnumerable<OutrosContatosModel> Buscar(string pessoas)
        {
            using (IXMLMaker xml = config.Consulta("PessoaOutroContato"))
            {
                xml.addMultiColumnsSelect(ColunasSimplesProtocolo());
                xml.addColumnSelect("Pessoa", "PessoaId");
                xml.addFilterColumnSelect("Pessoa", XMLMaker.EstaEm, pessoas);
                return xml.XmlModelReaderBySelectColumns<OutrosContatosModel>();
            }
        }

        private string ColunasSimplesProtocolo()
        {
            return "TipoContato, Contato, Complemento, Ramal, Comunicar";
        }
    }
}
