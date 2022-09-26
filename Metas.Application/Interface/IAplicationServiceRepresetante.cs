using Metas.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceRepresetante
    {
        Task<ForIndicadorSAP> OnGetFindIndicatorSAP(IndicadorDTO dto);
        Task<FormIndicador> OnGetListIndicatorAdd(EIndicadorAddDTO dto);
        Task<FormColaboradorDTO> OnGetFindColaborador(ColaboradorDTO dto);
        Task<int> OnSendForApprovalIndicador(GIndicadorDTTO dto);
        Task<int> OnRemoveIndicador(int idindicador);

    }
}
