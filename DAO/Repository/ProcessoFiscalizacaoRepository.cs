using System.Collections.Generic;
using System.Linq;
using Fiscalizacao.Models;
using Fiscalizacao.Repository;

namespace DAO.Repository
{
    public class ProcessoFiscalizacaoRepository
    {
        AppDBContext ctx;
        public ProcessoFiscalizacaoRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<ProcessoFiscalizacaoModel> models)
        {
            var lista = models.GroupBy(p => p.Id).Select(g => g.First()).ToList();

            var pessoas = models.Select(x => x.RepresentadoId).ToList();
            pessoas.AddRange(models.Select(x => x.RepresentanteId).ToList());
            new PessoaRepository(ctx).TratarPessoaNaoExistente(pessoas);

            ctx.ProcessoFiscalizacao.BulkUpdate(models);
            ctx.ProcessoFiscalizacao.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}