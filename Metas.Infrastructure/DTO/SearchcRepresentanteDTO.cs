using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Infrastructure.DTO
{
    public class SearchcRepresentanteDTO
    {
        public int PAGINA { get; private set; }
        public int IDFREQUENCIA { get; set; }
        public string BUSCA { get; set; }

        public SearchcRepresentanteDTO(int pagina, int frequencia, string busca)
        {
            PAGINA = pagina;
            IDFREQUENCIA = frequencia;
            BUSCA = busca;
        }

    }
}
