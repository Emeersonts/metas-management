using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class CronogramaAplicadoDTO
    {
        // Para uso do SaveSchedule
        public int IDTIPO { get; set; }
        public int IDCRONOGRAMA { get; set; }
        public int IDCELULATRABALHO { get; set; }
        public DateTime DATAPROGRAMADA { get; set; }
        public DateTime DATAREAL { get; set; }

        // Para uso do ListSchedule
        public string DESCRICAO { get; set; }
        public int ATIVO { get; set; }
    }
}
