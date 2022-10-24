using Metas.Application.DTO;
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
    }
}
