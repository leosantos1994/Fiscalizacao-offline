using Fiscalizacao.Models;
using Fiscalizacao.Repository;
using System.Collections.Generic;

namespace DAO.Repository
{
    public class TramiteRepository
    {
        AppDBContext ctx;
        public TramiteRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<ProcessoTramiteModel> models)
        {
            ctx.TramiteTedAdm.BulkUpdate(models);
            ctx.TramiteTedAdm.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}