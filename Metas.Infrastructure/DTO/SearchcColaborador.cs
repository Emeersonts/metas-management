using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Infrastructure.DTO
{
    public class SearchcColaborador
    {
        
        public int ANOCICLO { get; private set; }
        public int MES { get; private set; }

        public SearchcColaborador(int idciclo, int mes)
        {
            ANOCICLO = idciclo;
            MES = mes;
        }

        // Mes,Pagina
        public SearchcColaborador(int anociclo)
        {
            ANOCICLO = anociclo;
        }

    }
}
