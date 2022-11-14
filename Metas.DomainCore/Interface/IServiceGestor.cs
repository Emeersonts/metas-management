using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceGestor
    {
        Task<DataTable> GetGoalsReport(int ciclo);
        Task<DataTable> VializeTeam(int ciclo);
        Task<DataTable> GetFormTtype(int ciclo);
        Task<int> PutSaveFormEditType(TipoEdicaoFormulario parametrs);
        Task<DataTable> GetFindMeta(SearchcColaborador parameters, pkxd pkx);
        Task<DataTable> GetFindMetaResult(int ANOCICLO, int IDCELULATRABALHO, pkxd pkx);
        Task<DataTable> GetReviewResults(int ANOCICLO, int IDCELULATRABALHO);
        Task<DataTable> GetFindColaborador(int pagina, int qtpagina, int idcelulatrabalho);
        Task<DataTable> GetListsolicitation(SearchcSolicitgacaoDTO parameters, int ANOCICLO, int PAGINA, int NPAGINA, int IDCELULATRABALHO);
        Task<int> RequestAdjustment(int anociclo, int idcelulatrabalho, string menssagem);
        Task<int> AprovarIndicador(int anociclo, int idcelulatrabalho);
        Task<int> AprovarResults(int anociclo, int idcelulatrabalho);
        Task<int> RequestAdjustmentResult(int anociclo, int idcelulatrabalho, string menssagem);
    }
}
