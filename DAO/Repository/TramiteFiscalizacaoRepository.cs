using Fiscalizacao.Models;
using Fiscalizacao.Repository;
using System.Collections.Generic;

namespace DAO.Repository
{
    public class TramiteFiscalizacaoRepository
    {
        AppDBContext ctx;
        public TramiteFiscalizacaoRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<ProcessoTramiteFiscalizacaoModel> models)
        {
            ctx.TramiteFiscalizacao.BulkUpdate(models);
            ctx.TramiteFiscalizacao.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}