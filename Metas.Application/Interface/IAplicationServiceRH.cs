using Metas.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceRH
    {
        Task<ForDropGestorDTO> onGetListGestor();
    }
}
