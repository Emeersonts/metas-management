﻿using System;
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
        public decimal PESO { get; set; }
        public decimal MINIMO { get; set; }
        public decimal PLANEJADO { get; set; }
        public decimal DESAFIO { get; set; }
        public int IDCICLO { get; set; }
        public int IDFORMULARIOMETA { get; set; }
        public int IDCELULATRABALHO { get; set; }

        public Indicador(int idindicador, string nome, string descricaoindicador, int idunidademedida,
            int idfrequencia, decimal peso, decimal minimo, decimal planejado, decimal desafio, int idciclo,
            int idforumlariometa, int idcelulatrabalho
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
            IDCICLO = idciclo;
            IDFORMULARIOMETA = idforumlariometa;
            IDCELULATRABALHO = idcelulatrabalho;
        }


    }
}
