using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryGestor
    {
        Task<DataTable> RGetGoalsReport(int CICLO);
        Task<DataTable> RVializeTeam(int CICLO);
        Task<DataTable> RGetFormTtype(int CICLO);
        Task<int> RSaveFormEditType(TipoEdicaoFormulario tipoedicaoformularo);
        Task<DataTable> RGetFindMeta(SearchcColaborador dto, pkxd pkx);
        Task<DataTable> RGetFindMetaResult(int ANOCICLO, int IDCELULATRABALHO);
        Task<DataTable> RGetReviewResults(int anociclo, int idcelulatrabalho);
    }
}
