using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class Indicador
    {
        public int IDINDICADOR { get; set; }
        public string NOME { get; set; }
        public string DESCRICAOINDICADOR { get; set; }
        public int IDUNIDADEMEDIDA { get; set; }
        public int IDFREQUENCIA { get; set; }
        public int PESO { get; set; }
        public decimal MINIMO { get; set; }
        public decimal PLANEJADO { get; set; }
        public decimal DESAFIO { get; set; }
        public int ANOCICLO { get; set; }
        public int MES { get; set; }
        public decimal? APURADO { get; set; }
        public string ON { get; set; }

        public Indicador(int idindicador, string nome, string descricaoindicador, int idunidademedida,
            int idfrequencia, int peso, decimal minimo, decimal planejado, decimal desafio, int anocilo, int mes, decimal? apurado, string on
        )
        {
            IDINDICADOR = idindicador;
            NOME = nome;
            DESCRICAOINDICADOR = descricaoindicador;
            IDUNIDADEMEDIDA = idunidademedida;
            IDFREQUENCIA = idfrequencia;
            PESO = peso;
            MINIMO = minimo;
            PLANEJADO = planejado;
            DESAFIO = desafio;
            ANOCICLO = anocilo;
            MES = mes;
            APURADO = apurado;
            ON = on;
        }

    }
}
