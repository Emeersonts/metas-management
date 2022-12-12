using Metas.Application.DTO;
using Metas.Domain;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceCOE
    {
        Task<FormFormDTO> onGetListForm(int IDCELULATRABALHO);
        Task<ForUnidOperacionalDTO> onListOperatingUnit();
        Task<ForDropGestorDTO> onGetListGestor(int idunidadeoperacional);
        Task<ForCronogramaAplicadoDTO> onListSchedule();
        Task<int> onSaveSchedule(CronogramaAplicadoDTO dtoa);
        Task<int> OnSaveForm(IndicadorNegocioDTO dto);
        Task<FormIndicadorDTO> OnGetListIndicatorAdd(int idanociclo);
        Task<ForIndicadorSAP> OnGetIndicatorLibrary(EIndicatorLibraryDTO DTO);
        Task<int> OnSaveFormLibrary(EIndicadorSAPDTO dto);
    }
}
