using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class IndicadorDTO
    {
        public int PAGINA { get; set; }
        public int IDFREQUENCIA { get; set; }
        public string BUSCA { get; set; }
        public int IDINDICADOR { get; set; }

        public IndicadorDTO(int pagina, int idfrequencia, string busca)
        {
            PAGINA = pagina;
            IDFREQUENCIA = idfrequencia;
            BUSCA = busca;
        }
        
        public IndicadorDTO (int idindicador)
        {
            IDINDICADOR = idindicador;
        }
    }
}
