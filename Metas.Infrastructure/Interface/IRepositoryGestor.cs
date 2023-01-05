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
        Task<DataTable> RGetFindColaborador(int pagina,int qtpagina, int idcelulatrabalho, int anociclo);
        Task<DataTable> RGetListsolicitation(SearchcSolicitgacaoDTO dto, int anociclo, int pagina, int npagina, int idcelulatrabalho);
        Task<int> RRequestAdjustmentt(int ANOCICLO, int IDCELULATRABALHO, string MENSSAGEM);
        Task<int> RAprovarIndicador(int ANOCICLO, int IDCELULATRABALHO);
        Task<int> RAprovarResults(int ANOCICLO, int IDCELULATRABALHO);
        Task<int> RAprovarResultsJul(int ANOCICLO, int IDCELULATRABALHO);
        Task<int> RRequestAdjustmentResult(int ANOCICLO, int IDCELULATRABALHO, string MENSSAGEM);
    }
}
