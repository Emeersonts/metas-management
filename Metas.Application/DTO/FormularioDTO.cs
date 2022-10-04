using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class FormularioDTO
    {
        public int IDFORMULARIOMETA { get; set; }
        public String NOMEFORMULARIO { get; set; }
        public int IDCELULATRABALHO { get; set; }
        public IEnumerable<MetasDTO> ListMeta { get; set; }
    }
}
