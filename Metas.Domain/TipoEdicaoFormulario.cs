using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class TipoEdicaoFormulario
    {
        public int ANOCICLO { get; set; }
        public int IDTIPOEDICAOFORMULARIO { get; set; }
        public int IDREPRESENTANTE { get; set; }
        public int IDSUPLENTE { get; set; }
        public int IDCELULATRABALHO { get; set; }
        public int MESTRANFERENCIA { get; set; }

        public TipoEdicaoFormulario(int anociclo, int idtipoedicaoformulario, int idrepresentante, int idsuplente, 
            int idcelulatrabalho,  int mestransferencia
        )
        {
            ANOCICLO = anociclo;
            IDTIPOEDICAOFORMULARIO = idtipoedicaoformulario;
            IDREPRESENTANTE = idrepresentante;
            IDSUPLENTE = idsuplente;
            IDCELULATRABALHO = idcelulatrabalho;
            MESTRANFERENCIA = mestransferencia;
        }
    }
}
