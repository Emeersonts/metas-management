using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class MetasDTO
    {
        public string NOMECLICLO { get; set; }
        public int IDINDICADOR { get; set; }
        public String NOMEINDICADOR { get; set; }
        public String NOMEUNIDADEMEDIDA { get; set; }
        public String DESCRICAO { get; set; }
        public Decimal PESO { get; set; }
        public Decimal MINIMO { get; set; }
        public Decimal PLANEJADO { get; set; }
        public Decimal DESAFIO { get; set; }
        public Decimal RESULTADOAPURADO { get; set; } 
        public Decimal SIMULADOAPURADO { get; set; }
        public DateTime DATAAPURACAO { get; set; }

        public MetasDTO(string nomeciclo, int idindicador,string nomeindicador, string nomeunidademedida, string descricao,decimal peso, decimal minimo,
            decimal planejado,decimal desafio, decimal resultadoapurado, decimal simuladoaapurado, DateTime dataapuracao)
        {
            NOMECLICLO = nomeciclo;
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
        }

        public MetasDTO()
        {

        }
    }
}