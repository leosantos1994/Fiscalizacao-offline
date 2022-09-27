using DAO.Repository;
using Fiscalizacao.Models;
using Fiscalizacao.Quellon;
using Fiscalizacao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscalizacao.DAO
{
    public class SincronizarBase
    {
        public void Iniciar(string site, string user, string pass)
        {
            QuellonConfig.Instancia.Login(site, user, pass);

            var dao = new QuellonPessoaDAO(QuellonConfig.Instancia);
            var daoprotocolo = new QuellonProtocoloDAO(QuellonConfig.Instancia);
            var daofinanceiro = new QuellonFinanceiroDAO(QuellonConfig.Instancia);
            var daoformacao = new QuellonFormacaoAcademicaDAO(QuellonConfig.Instancia);
            var daoinscricao = new QuellonHistoricoInscricaoDAO(QuellonConfig.Instancia);
            var daoocorrencia = new QuellonHistoricoOcorrenciaDAO(QuellonConfig.Instancia);
            var daocontatos = new QuellonOutrosContatosDAO(QuellonConfig.Instancia);
            var daovinculos = new QuellonVinculoProfissionalDAO(QuellonConfig.Instancia);
            var daoprocessos = new QuellonProcessosDAO(QuellonConfig.Instancia);
            var daoprocessosFis = new QuellonProcessoFiscalizacaoDAO(QuellonConfig.Instancia);
            var daoTramite = new QuellonProcessoTramiteDAO(QuellonConfig.Instancia);
            var daoTramiteFis = new QuellonProcessoTramiteFiscalizacaoDAO(QuellonConfig.Instancia);

            var ctx = new AppDBContext();
            var repo = new PessoaRepository(ctx);

            var result = dao.BuscarInformacoesPessoas("");
            repo.InsereOuAtualiza(result);

            string pessoas = string.Join(",", result.Select(pessoa => pessoa.Id).ToArray());

            var listaProcessos = daoprocessos.Buscar(pessoas).ToList();
            var listaProcessosFis = daoprocessosFis.Buscar(pessoas).ToList();

            string processos = string.Join(",", listaProcessos.Select(processo => processo.Id).ToArray());
            string processosFis = string.Join(",", listaProcessosFis.Select(processo => processo.Id).ToArray());

            //processo adm
            new ProcessoRepository(ctx).InsereOuAtualiza(listaProcessos);

            //processo fis
            new ProcessoFiscalizacaoRepository(ctx).InsereOuAtualiza(listaProcessosFis);

            //tramite adm
            new TramiteRepository(ctx).InsereOuAtualiza(daoTramite.Buscar(processos).ToList());

            //tramite fis
            new TramiteFiscalizacaoRepository(ctx).InsereOuAtualiza(daoTramiteFis.Buscar(processosFis).ToList());

            //protocolo
            new ProtocoloRepository(ctx).InsereOuAtualiza(daoprotocolo.Buscar(pessoas));

            //financeiro
            new FinanceiroRepository(ctx).InsereOuAtualiza(daofinanceiro.Buscar(pessoas));

            //formacao
            new FormacaoAcademicaRepository(ctx).InsereOuAtualiza(daoformacao.Buscar(pessoas));

            //inscricao
            new HistoricoInscricaoRepository(ctx).InsereOuAtualiza(daoinscricao.Buscar(pessoas));

            //ocorrencia
            new HistoricoOcorrenciaRepository(ctx).InsereOuAtualiza(daoocorrencia.Buscar(pessoas));

            //contatos
            new OutrosContatosRepository(ctx).InsereOuAtualiza(daocontatos.Buscar(pessoas));

            //vinculos
            new VinculoProfissionalRepository(ctx).InsereOuAtualiza(daovinculos.Buscar(pessoas));
        }

        public void IniciarMarciel(string site, string user, string pass)
        {
            QuellonConfig.Instancia.Login(site, user, pass);

            var dao = new QuellonPessoaDAO(QuellonConfig.Instancia);
            var daoprotocolo = new QuellonProtocoloDAO(QuellonConfig.Instancia);
            var daofinanceiro = new QuellonFinanceiroDAO(QuellonConfig.Instancia);
            var daoformacao = new QuellonFormacaoAcademicaDAO(QuellonConfig.Instancia);
            var daoinscricao = new QuellonHistoricoInscricaoDAO(QuellonConfig.Instancia);
            var daoocorrencia = new QuellonHistoricoOcorrenciaDAO(QuellonConfig.Instancia);
            var daocontatos = new QuellonOutrosContatosDAO(QuellonConfig.Instancia);
            var daovinculos = new QuellonVinculoProfissionalDAO(QuellonConfig.Instancia);
            var daoprocessos = new QuellonProcessosDAO(QuellonConfig.Instancia);
            var daoprocessosFis = new QuellonProcessoFiscalizacaoDAO(QuellonConfig.Instancia);
            var daoTramite = new QuellonProcessoTramiteDAO(QuellonConfig.Instancia);
            var daoTramiteFis = new QuellonProcessoTramiteFiscalizacaoDAO(QuellonConfig.Instancia);

            var ctx = new AppDBContext();
            var repo = new PessoaRepository(ctx);

            var result = dao.BuscarInformacoesPessoas(135640.ToString());
            repo.InsereOuAtualiza(result);

            string pessoas = string.Join(",", result.Select(pessoa => pessoa.Id).ToArray());

            var listaProcessos = daoprocessos.Buscar(pessoas).ToList();
            var listaProcessosFis = daoprocessosFis.Buscar(pessoas).ToList();

            string processos = string.Join(",", listaProcessos.Select(processo => processo.Id).ToArray());
            string processosFis = string.Join(",", listaProcessosFis.Select(processo => processo.Id).ToArray());

            //processo adm
            new ProcessoRepository(ctx).InsereOuAtualiza(listaProcessos);

            //processo fis
            new ProcessoFiscalizacaoRepository(ctx).InsereOuAtualiza(listaProcessosFis);

            //tramite adm
            new TramiteRepository(ctx).InsereOuAtualiza(daoTramite.Buscar(processos).ToList());

            //tramite fis
            new TramiteFiscalizacaoRepository(ctx).InsereOuAtualiza(daoTramiteFis.Buscar(processosFis).ToList());

            //protocolo
            new ProtocoloRepository(ctx).InsereOuAtualiza(daoprotocolo.Buscar(pessoas));

            //financeiro
            new FinanceiroRepository(ctx).InsereOuAtualiza(daofinanceiro.Buscar(pessoas));

            //formacao
            new FormacaoAcademicaRepository(ctx).InsereOuAtualiza(daoformacao.Buscar(pessoas));

            //inscricao
            new HistoricoInscricaoRepository(ctx).InsereOuAtualiza(daoinscricao.Buscar(pessoas));

            //ocorrencia
            new HistoricoOcorrenciaRepository(ctx).InsereOuAtualiza(daoocorrencia.Buscar(pessoas));

            //contatos
            new OutrosContatosRepository(ctx).InsereOuAtualiza(daocontatos.Buscar(pessoas));

            //vinculos
            new VinculoProfissionalRepository(ctx).InsereOuAtualiza(daovinculos.Buscar(pessoas));
        }

    }
}
