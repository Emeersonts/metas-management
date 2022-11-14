using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class GestorStatusDTO
    {
        public int NPESSOAL { get; set; }
        public string NOMECOMPLETO { get; set; }
        public string NOMEFORMULARIO { get; set; }
        public Decimal RITMO { get; set; }
        public string DESCRICAOSTATUS { get; set; }
        public DateTime DATASTATUS { get; set; }
        public int PG { get; set; }
        public string ATA { get; set; }

    }

}
