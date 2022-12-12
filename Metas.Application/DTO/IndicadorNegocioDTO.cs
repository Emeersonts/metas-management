using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class IndicadorNegocioDTO
    {
        public int IDINDICADOR { get; set; }
        public string NOME { get; set; }
        public int IDUNIDADEMEDIDA { get; set; }
        public int IDFREQUENCIA { get; set; }
        public int PESO { get; set; }
        public decimal MINIMO { get; set; }
        public decimal PLANEJADO { get; set; }
        public decimal DESAFIO { get; set; }
        public int ANOCICLO { get; set; }
        public decimal APURADO { get; set; }
        public int ON { get; set; }
    }
}
