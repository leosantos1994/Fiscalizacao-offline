using Fiscalizacao.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fiscalizacao.Repository
{
    public class FinanceiroRepository
    {
        AppDBContext ctx;
        public FinanceiroRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<FinanceiroModel> models)
        {
            ctx.Financeiro.BulkUpdate(models);
            ctx.Financeiro.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }

        public FinanceiroModel BuscarPorId(int id)
        {
            return ctx.Financeiro
              .FirstOrDefault(x => x.Id == id);
        }
    }
}
