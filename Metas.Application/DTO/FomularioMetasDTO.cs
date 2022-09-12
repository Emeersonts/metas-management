using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class FormularioMetasDTO
    {
            public int idstatus { get; set; }
            public string nomestatus { get; set; }
            public IEnumerable<MetasDTO> ListMeta { get; set; }
    }
}
