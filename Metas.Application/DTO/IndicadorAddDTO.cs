using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class IndicadorAddDTO
    {
        public int IDINDICADOR { get; set; }
        public string NOMEINDICADOR { get; set; }
        public int IDUNIDADEMEDIDA { get; set; }
        public String NOMEUNIDADEMEDIDA { get; set; }
        public string NOME { get; set; }
        public int IDFREQUENCIA { get; set; }
        public string DESCRICAO { get; set; }
        public int PESO { get; set; }
        public Decimal MINIMO { get; set; }
        public Decimal PLANEJADO { get; set; }
        public Decimal DESAFIO { get; set; }
        public String DESCRICAOINDICADOR { get; set; }
        public int RESULTADO { get; set; }
        public decimal APURADO { get; set; }
        public int ORDEMINICIO { get; set; }
        public int STATUSMETA { get; set; }
        public int STATUSRESULTADO { get; set; }
    }
}
