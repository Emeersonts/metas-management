using Metas.Application.DTO;
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
        Task<int> onSaveSchedule(CronogramaAplicadoDTO[] dto);
        Task<int> OnSaveForm(int idcelulatrabalho, GIndicadorDTTO dto, int operacao);
        Task<FormIndicadorDTO> OnGetListIndicatorAdd(int idcelulatrabalho);
    }
}
