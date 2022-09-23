using Fiscalizacao.Models;
using Fiscalizacao.Quellon;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;
using System;

namespace Fiscalizacao.Repository
{
    public class PessoaRepository
    {
        AppDBContext ctx;
        public PessoaRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<PessoaModel> models)
        {
            ctx.Pessoa.BulkUpdate(models);
            ctx.Pessoa.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }

        public IEnumerable<PessoaModel> BuscarTodosIncluding()
        {
            return ctx.Pessoa
                .Include(x => x.ProcessoRepresentado)
                .Include(x => x.ProcessoRepresentate)
                .Include(x => x.ProcessoRepresentadoFiscalizacao)
                .Include(x => x.ProcessoRepresentateFiscalizacao)
                .Include(x => x.Financeiro)
                .Include(x => x.Protocolo)
                .Include(x => x.ProtocoloPJ)
                .Include(x => x.VinculoProfissional)
                .Include(x => x.VinculoProfissionalPJ)
                .Include(x => x.OutrosContatos)
                .Include(x => x.Inscricao)
                .Include(x => x.Ocorrencia)
                .Include(x => x.Formacao);
        }

        public IEnumerable<PessoaModel> BuscarTodos()
        {
            return ctx.Pessoa;
        }

        public IEnumerable<PessoaModel> BuscarTodos(Expression<Func<PessoaModel, bool>> predicate)
        {
            return ctx.Pessoa.Where(predicate);
        }

        public PessoaModel BuscarPorId(int id)
        {
            return ctx.Pessoa
               .Include(x => x.ProcessoRepresentado)
               .Include(x => x.ProcessoRepresentate)
               .Include(x => x.ProcessoRepresentadoFiscalizacao)
               .Include(x => x.ProcessoRepresentateFiscalizacao)
               .Include(x => x.Financeiro)
               .Include(x => x.Protocolo)
               .Include(x => x.ProtocoloPJ)
               .Include(x => x.VinculoProfissional)
               .Include(x => x.VinculoProfissionalPJ)
               .Include(x => x.OutrosContatos)
               .Include(x => x.Inscricao)
               .Include(x => x.Ocorrencia)
               .Include(x => x.Formacao).FirstOrDefault(x => x.Id == id);
        }

        public bool PessoaExiste(int id) => ctx.Pessoa.Any(p => p.Id == id);

        public void TratarPessoaNaoExistente(List<int?> pessoas)
        {
            var pessoaDAO = new QuellonPessoaDAO(QuellonConfig.Instancia);
            foreach (var pessoa in pessoas)
            {
                if (pessoa != null && !PessoaExiste(pessoa.Value))
                {
                    InsereOuAtualiza(pessoaDAO.BuscarInformacoesPessoas(pessoa.ToString()));
                }
                if (pessoa != null && !PessoaExiste(pessoa.Value))
                {
                    InsereOuAtualiza(pessoaDAO.BuscarInformacoesPessoas(pessoa.ToString()));
                }
            }
        }
    }
}
