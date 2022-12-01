using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class CronogramaAplicadoDTO
    {
        public int IDCRONOGRAMA { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime DATAPROGRAMADA { get; set; }
        public int ATIVO { get; set; }
    }
}
