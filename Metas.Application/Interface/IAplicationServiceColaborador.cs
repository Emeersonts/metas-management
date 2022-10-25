using Metas.Application.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceColaborador
    {
        Task<FormularioMetasDTO> OnGetFindMeta(CicloUsuarioDTO dto, pkxd pkx);
        Task<ForMetasResultDTO> OnGetFindMetaResult(int anociclo, pkxd pkx);
        Task<FormularioResultadoMeta> OnGetFindAfastamento(int ciclo);
    }
}
