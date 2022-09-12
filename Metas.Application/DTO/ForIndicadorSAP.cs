using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class ForIndicadorSAP
    {
        public int PGTOTAL { get; set; }
        public IEnumerable<IndicadorSAPDTO> ListIndicadorSAP { get; set; }
    }
}
