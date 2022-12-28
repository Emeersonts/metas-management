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
        public string MINIMO { get; set; }
        public string PLANEJADO { get; set; }
        public string DESAFIO { get; set; }
        public String DESCRICAOINDICADOR { get; set; }
        public int RESULTADO { get; set; }
        public decimal APURADO { get; set; }
        public int ORDEMINICIO { get; set; }
        public int STATUSMETA { get; set; }
        public int STATUSRESULTADO { get; set; }
        public decimal SIMULADOAPURADO { get; set; }
        public DateTime DATAAPURACAO { get; set; }
        public int STATUSINDICADOR { get; set; }
        public string OPNEG { get; set; }
    }
}
