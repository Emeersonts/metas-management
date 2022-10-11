using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class SolicitacaoDTO
    {
        public String TITULO { get; set; }
        public String ORIGEM { get; set; }
        public String RESPONSAVEL { get; set; }
        public DateTime ABERTURA { get; set; }
        public DateTime CONCLUSAO { get; set; }
        public String STATUS { get; set; }
        public String DESCRICAO { get; set; }
    }
}
