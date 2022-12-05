using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class ForSolicitacaoDTO
    {
        public int PGTOTAL { get; set; }
        public IEnumerable<SolicitacaoDTO> ListSolicitacao { get; set; }
    }
}
