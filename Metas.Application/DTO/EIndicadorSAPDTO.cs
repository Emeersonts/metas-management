using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class EIndicadorSAPDTO
    {
        public int IDINDICADOR { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public int IDUNIDADEMEDIDA { get; set; }
        public int IDFREQUENCIA { get; set; }
        public DateTime DATAINI { get; set; }
        public DateTime DATAFIM { get; set; }
    }
}
