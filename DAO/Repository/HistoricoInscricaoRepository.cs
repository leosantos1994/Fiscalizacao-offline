using Fiscalizacao.Models;
using System.Collections.Generic;

namespace Fiscalizacao.Repository
{
    public class HistoricoInscricaoRepository
    {
        AppDBContext ctx;
        public HistoricoInscricaoRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<HistoricoInscricaoModel> models)
        {
            ctx.Inscricao.BulkUpdate(models);
            ctx.Inscricao.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}

