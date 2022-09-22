using Fiscalizacao.Models;
using System.Collections.Generic;

namespace Fiscalizacao.Repository
{
    public class OutrosContatosRepository
    {
        AppDBContext ctx;
        public OutrosContatosRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<OutrosContatosModel> models)
        {
            ctx.OutroContato.BulkUpdate(models);
            ctx.OutroContato.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}
