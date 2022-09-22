using System.Collections.Generic;
using Fiscalizacao.Models;
using System.Linq;

namespace Fiscalizacao.Repository
{
    public class ProcessoRepository
    {
        AppDBContext ctx;
        public ProcessoRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<ProcessoModel> models)
        {
            var lista = models.GroupBy(p => p.Id).Select(g => g.First()).ToList();

            var pessoas = models.Select(x => x.RepresentadoId).ToList();
            pessoas.AddRange(models.Select(x => x.RepresentanteId).ToList());
            new PessoaRepository(ctx).TratarPessoaNaoExistente(pessoas);


            ctx.ProcessoTedAdm.BulkUpdate(models);

            ctx.ProcessoTedAdm.BulkInsert(lista, (o) => { o.InsertIfNotExists = true; });
        }
    }
}
