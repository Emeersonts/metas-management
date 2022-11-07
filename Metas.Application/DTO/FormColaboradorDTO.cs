using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class FormColaboradorDTO
    {
        public int PGTOTAL { get; set; }
        public int NCOLABORADOR { get; set; }
        public String DESCRICAOCELULATRABALHO { get; set; }
        public IEnumerable<RColaboradorDTO> ListColaborador { get; set; }
    }
}
