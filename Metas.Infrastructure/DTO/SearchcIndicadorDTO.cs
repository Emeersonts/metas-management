using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Infrastructure.DTO
{
    public class SearchcIndicadorDTO
    {
        public string INDICADORES { get; private set; }

        public SearchcIndicadorDTO(string indicadores)
        {
            INDICADORES = indicadores;
        }

    }
}
