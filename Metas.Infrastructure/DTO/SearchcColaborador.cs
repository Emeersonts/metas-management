using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Infrastructure.DTO
{
    public class SearchcColaborador
    {
        
        public int ANOCICLO { get; private set; }
        public int MES { get; private set; }
        public int IDCELULATRABALHO { get; set; }

        public SearchcColaborador(int idciclo, int mes)
        {
            ANOCICLO = idciclo;
            MES = mes;
        }

        public SearchcColaborador(int anociclo, int mes, int idcelulatrabalho)
        {
            ANOCICLO = anociclo;
            MES = mes;
            IDCELULATRABALHO = idcelulatrabalho;
        }

    }
}
