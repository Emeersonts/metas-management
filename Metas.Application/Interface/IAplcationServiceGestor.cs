using Metas.Application.DTO;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplcationServiceGestor
    {
        Task<ForEquipeDTO> OnVializeTeam(int ciclo);
        Task<ForTipóEdicaoDTO> OnGetFormTtype(int ciclo);
        Task<int> onSaveFormEditType(TipoEdicaoformularioDTO dto);
        Task<FormularioMetasDTO> OnGetFindMeta(CicloCelulaDTO dto, pkxd pkx);
        Task<FormRevisaoResultadoDTO> OnGetReviewResults(int anociclo, int idcelulatrabalho);
        Task<ForMetasResultDTO> OnGetFindMetaResult(int anociclo, int idcelulatrabalho, pkxd pkx);
        Task<FormColaboradorDTO> OnGetFindColaborador(int pagina, int qtpagina, int idcelulatrabalho);
        Task<ForSolicitacaoDTO> OnGetListsolicitation(ESolicitacaoDTO dto, int anociclo,int idcelulatrabalho);
        Task<int> OnRequestAdjustment(int anociclo, int idcelulatrabalho, string menssagem);
        Task<int> OnAprovarIndicador(int anociclo, int idcelulatrabalho);
        Task<int> OnAprovarResults(int anociclo, int idcelulatrabalho);
        Task<int> OnRequestAdjustmentResult(int anociclo, int idcelulatrabalho, string menssagem);
    }
}
