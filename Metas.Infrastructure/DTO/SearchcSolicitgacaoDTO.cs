using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Infrastructure.DTO
{
    public class SearchcSolicitgacaoDTO
    {
        public string BUSCA { get; set; }
        public Byte ORIGEM { get; set; }
        public Byte RESPONSAVEL { get; set; }
        public Byte STATUS { get; set; }

        public SearchcSolicitgacaoDTO(string busca, byte origem, byte responsavel, byte status)
        {
            BUSCA = busca;
            ORIGEM = origem;
            RESPONSAVEL = responsavel;
            STATUS = status;
        }
    }
}
