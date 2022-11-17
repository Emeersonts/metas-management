using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class ForMetaRelatorioDTO
    {
        public String DESCRICAOSTATUS { get; set; }
        public int IDSTATUSCICLO { get; set; }
        public IEnumerable<MetasDTO> ListMeta { get; set; }
    }
}
