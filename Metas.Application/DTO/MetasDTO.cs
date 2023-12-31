﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class MetasDTO
    {
        public int IDINDICADOR { get; set; }
        public int MESINICIO { get; set; }
        public int IDCELULATRABALHO { get; set; }
        public string NOMEFORMULARIO { get; set; }
        public String NOMEINDICADOR { get; set; }
        public String NOMEUNIDADEMEDIDA { get; set; }
        public String DESCRICAO { get; set; }
        public int PESO { get; set; }
        public string MINIMO { get; set; }
        public string PLANEJADO { get; set; }
        public string DESAFIO { get; set; }
        public Decimal RESULTADOAPURADO { get; set; } 
        public Decimal SIMULADOAPURADO { get; set; }
        public DateTime DATAAPURACAO { get; set; }
        public int RESULTADO { get; set; }
        public int ORDEMINICIO { get; set; }

        public MetasDTO(int idcelulatrabalho, string nomeformulario, int idindicador,string nomeindicador, string nomeunidademedida, string descricao, int peso, string minimo,
            string planejado, string desafio, decimal resultadoapurado, decimal simuladoaapurado, DateTime dataapuracao, int ordeminicio)
        {
            IDCELULATRABALHO = idcelulatrabalho;
            NOMEFORMULARIO = nomeformulario;
            IDINDICADOR = idindicador;
            NOMEINDICADOR = nomeindicador;
            NOMEUNIDADEMEDIDA = nomeunidademedida;
            DESCRICAO = descricao;
            PESO = peso;
            MINIMO = minimo;
            PLANEJADO = planejado;
            DESAFIO = desafio;
            RESULTADOAPURADO = RESULTADOAPURADO;
            SIMULADOAPURADO = simuladoaapurado;
            DATAAPURACAO = dataapuracao;
            ORDEMINICIO = ORDEMINICIO;
        }

        public MetasDTO()
        {

        }
    }
}