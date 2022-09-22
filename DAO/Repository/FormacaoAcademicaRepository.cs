using Fiscalizacao.Models;
using System.Collections.Generic;



namespace Fiscalizacao.Repository
{
    public class FormacaoAcademicaRepository
    {
        AppDBContext ctx;
        public FormacaoAcademicaRepository(AppDBContext context)
        {
            ctx = context;
        }

        public void InsereOuAtualiza(IEnumerable<FormacaoAcademicaModel> models)
        {
            ctx.Formacao.BulkUpdate(models);
            ctx.Formacao.BulkInsert(models, (o) => { o.InsertIfNotExists = true; });
        }
    }
}
