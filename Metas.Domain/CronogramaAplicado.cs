using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class CronogramaAplicado
    {
        public int TIPO { get; set; }
        public int CRONOGRAMA { get; set; }
        public int CELULATRABALHO { get; set; }
        public DateTime DATAPROGRAMADA { get; set; }
        public DateTime DATAREAL { get; set; }

        public CronogramaAplicado(int idTipo, int idCronograma, int idCelulaTrabalho, DateTime dataProgramada, DateTime dataReal)
        {
            TIPO = idTipo;
            CRONOGRAMA = idCronograma;
            CELULATRABALHO = idCelulaTrabalho;
            DATAPROGRAMADA = dataProgramada;
            DATAREAL = dataReal;
        }
    }
}
