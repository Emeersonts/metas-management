using Metas.Application.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
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
    }
}
