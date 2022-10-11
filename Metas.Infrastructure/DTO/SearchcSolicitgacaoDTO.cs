using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Infrastructure.DTO
{
    public class SearchcSolicitgacaoDTO
    {
        public string BUSCA { get; set; }
        public Byte ORIGEM { get; set; }
        public Byte RESPONSACAL { get; set; }
        public Byte STATUS { get; set; }

        public SearchcSolicitgacaoDTO(string busca, byte origem, byte responsavel, byte status)
        {
            BUSCA = busca;
            ORIGEM = origem;
            RESPONSACAL = responsavel;
            STATUS = status;
        }
    }
}
