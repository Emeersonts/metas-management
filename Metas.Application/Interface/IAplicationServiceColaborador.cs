using Metas.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceColaborador
    {
        Task<FormularioMetasDTO> OnGetFindMeta(CicloUsuarioDTO dto);
        Task<ForMetasResultDTO> OnGetFindMetaResult(CicloUsuarioDTO dto);
        Task<FormularioResultadoMeta> OnGetFindAfastamento(int ciclo);
    }
}
