using Fiscalizacao.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fiscalizacao.Repository
{
    public class ProtocoloRepository
    {
        AppDBContext ctx;
        public ProtocoloRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<ProtocoloModel> models)
        {
            var lista = models.GroupBy(p => p.Id).Select(g => g.First()).ToList();

            var pessoas = models.Select(x => x.PessoaId).ToList();
            pessoas.AddRange(models.Select(x => x.PessoaJuridicaId).ToList());
            new PessoaRepository(ctx).TratarPessoaNaoExistente(pessoas);

            ctx.Protocolo.BulkUpdate(models);
            ctx.Protocolo.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}
