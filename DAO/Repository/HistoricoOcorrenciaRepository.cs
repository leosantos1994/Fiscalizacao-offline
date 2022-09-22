using Fiscalizacao.Models;
using System.Collections.Generic;

namespace Fiscalizacao.Repository
{
   public class HistoricoOcorrenciaRepository
    {
        AppDBContext ctx;
        public HistoricoOcorrenciaRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<HistoricoOcorrenciaModel> models)
        {
            ctx.Ocorrencia.BulkUpdate(models);
            ctx.Ocorrencia.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}
