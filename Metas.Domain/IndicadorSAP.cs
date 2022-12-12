using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class IndicadorSAP
    {
        public int IDINDICADOR { get; set; }
        public string NOME { get; set; }
        public string DESCRICAOINDICADOR { get; set; }
        public int IDUNIDADEMEDIDA { get; set; }
        public int IDFREQUENCIA { get; set; }
        public DateTime DATAINI { get; set; }
        public DateTime DATAFIM { get; set; }

        public IndicadorSAP(int idindicador, string nome, string descricaoindicador, int idunidademedida,
            int idfrequencia, DateTime datainid, DateTime datafim)
        {
            IDINDICADOR = idindicador;
            NOME = nome;
            DESCRICAOINDICADOR = descricaoindicador;
            IDUNIDADEMEDIDA = idunidademedida;
            IDFREQUENCIA = idfrequencia;
            DATAINI = datainid;
            DATAFIM = datafim;
        }
    }
}
