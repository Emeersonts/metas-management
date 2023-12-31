﻿using Metas.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceCiclo 
    {
        Task<ListStatusAtribuidoDTO> OnGetListProgressStatus(int ciclo);
        Task<ListCicloDTO> OnGetListCiclo();
    }
}
