using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class RevisaoResultadoDTO
    {
        public int IDMETA { get; set; }
        public string NOMEINDICADOR { get; set; }
        public string NOMEFREQUENCIA { get; set; }
        public string NOMEUNIDADEMEDIDA { get; set; }
        public int PESO { get; set; }
        public Decimal JAN { get; set; }
        public Decimal FEV { get; set; }
        public Decimal MAR { get; set; }
        public Decimal ABR { get; set; }
        public Decimal MAI { get; set; }
        public Decimal JUN { get; set; }
        public Decimal JUL { get; set; }
        public Decimal AGO { get; set; }
        public Decimal SET { get; set; }
        public Decimal OUT { get; set; }
        public Decimal NOV { get; set; }
        public Decimal DEZ { get; set; }
    }
}
