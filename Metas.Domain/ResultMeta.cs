using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class ResultMeta
    {
        //Contem assinaturas diferetens
        public int IDINDICADOR { get; set; }
        public string NOMEINDICADOR { get; set; }
        public string NOMEUNIDADEMEDIDA { get; set; }
        public string DESCRICAO { get; set; }
        public int PESO { get; set; }
        public decimal MINIMO { get; set; }
        public decimal PLANEJADO { get; set; }
        public decimal DESAFIO { get; set; }
        public decimal RESULTADOAPURADO { get; set; }
        public decimal SIMULADOAPURADO { get; set; }
        public DateTime DTAAPURACAO { get; set; }

    }
}
