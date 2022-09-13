using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class MetaResultDTO
    {
        public int IDCICLO { get; set; }
        public decimal APURADO { get; set; }
        public DateTime DATAAPURACAO { get; set; }
        public string DESCRICAO { get; set; }
    }
}
