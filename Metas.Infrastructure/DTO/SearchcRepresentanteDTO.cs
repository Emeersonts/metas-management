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
        public int IDCELULATRABALHO { get; set; }

        public SearchcRepresentanteDTO(int pagina, int frequencia, string busca)
        {
            PAGINA = pagina;
            IDFREQUENCIA = frequencia;
            BUSCA = busca;
        }

        public SearchcRepresentanteDTO(int pagina)
        {
            PAGINA = pagina;
        }

        public SearchcRepresentanteDTO(int pagina , int idfrequencia)
        {
            PAGINA = pagina;
            IDFREQUENCIA = idfrequencia;
        }

        public SearchcRepresentanteDTO(int pagina, int idfrequencia, int idcelulatrabalho)
        {
            PAGINA = pagina;
            IDFREQUENCIA = idfrequencia;
            IDCELULATRABALHO = idcelulatrabalho;
        }

    }
}
