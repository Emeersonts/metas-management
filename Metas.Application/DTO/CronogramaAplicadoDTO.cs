using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class CronogramaAplicadoDTO
    {
        public int IDTIPO { get; set; }
        public int IDCRONOGRAMA { get; set; }
        public int IDCELULATRABALHO { get; set; }
        public DateTime DATAPROGRAMADA { get; set; }
        public DateTime DATAREAL { get; set; }
    }
}
