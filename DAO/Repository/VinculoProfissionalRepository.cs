using System.Collections.Generic;
using System.Linq;
using Fiscalizacao.Models;


namespace Fiscalizacao.Repository
{
    public class VinculoProfissionalRepository
    {
        AppDBContext ctx;
        public VinculoProfissionalRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<VinculoProfissionalModel> models)
        {
            var lista = models.GroupBy(p => p.Id).Select(g => g.First()).ToList();

            var pessoas = models.Select(x => x.PessoaId).ToList();
            pessoas.AddRange(models.Select(x => x.PessoaJuridicaId).ToList());
            new PessoaRepository(ctx).TratarPessoaNaoExistente(pessoas);

            ctx.VinculoProfissional.BulkUpdate(models);
            ctx.VinculoProfissional.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}