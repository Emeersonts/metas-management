using Metas.Application.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceRepresetante
    {
        Task<ForIndicadorSAP> OnGetFindIndicatorSAP(IndicadorDTO dto);
        Task<FormIndicadorDTO> OnGetListIndicatorAdd(EIndicadorAddDTO dto, pkxd pkx);
        Task<ForMetaRelatorioDTO> OnGetGoalsReport(int CICLO, pkxd pkx);
        Task<FormRevisaoResultadoDTO> OnGetAddSIndicator(int CICLO);
        Task<ForSolicitacaoDTO> OnGetListsolicitation(ESolicitacaoDTO dto, int anociclo);
        Task<FormColaboradorDTO> OnGetFindColaborador(int pagina, int qtpagina);
        Task<ForCronogramaDTO> OnTimeline();
        Task<int> OnSaveForm(GIndicadorDTTO dto);
        Task<int> OnSendForApprovalIndicador(int anociclo);
        Task<int> OnSendResultForApproval(int anociclo);
        Task<int> OnRemoveIndicador(int idindicador);

    }
}
