using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Infrastructure.DTO
{
    public class SearchcIndicadorDTO
    {
        public string INDICADORES { get; private set; }
        public int MES { get; set; }
        public SearchcIndicadorDTO(string indicadores, int mes)
        {
            INDICADORES = indicadores;
            MES = mes;
        }

    }
}
