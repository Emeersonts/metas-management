using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Application.DTO
{
    public class InterrupcaoDTO
    {
        public String IT(int MSG)
        {
            switch (MSG)
            {
                case 1:
                    return "01-Este indicador já foi aprovado. Não pode ser removido <>";
                case 2:
                    return "02-A soma geral do peso dever ser igual a 100 % <>";
                case 3:
                    return "03-São seis metas no máximo cadastras por UO <>";
                case 4:
                    return "04-O indicador EBTIDA não pode ser removido <>";
                case 5:
                    return "05-A solicitação de aprovação já foi enviada e aguarda aprovação/ajuste <>";
                case 6:
                    return "06-Não existem registros de indicadores, para a solicitação de aprovação <>";
                case 7:
                    return "07-Não existem resultados para solicitação de aprovação <>";
                case 8:
                    return "08-Os indicadores já foram aprovados, não podem sofrer alteração <>";
                case 9:
                    return "09-Não existem registros de indicadores, para a solicitação de ajuste <>";
                case 10:
                    return "10-Já foi solicitado ajuste nos indicadores <>";
                case 11:
                    return "11-Mínimo, desafio e planejado deve ser crescentes ou decrecentes <>";
                case 12:
                    return "12-A solicitação de aprovação de resultado deve ser enviada apos aprovação de indicador de resultado <>";
                case 13:
                    return "13-Já foi solicitado ajuste nos resultados <>";
                case 14:
                    return "14-Não ha registro de resultados com pedido de aprovação <>";
                case 15:
                    return "15-Os resultados já foram aprovados, não podem ser modificados <>";
                case 16:
                    return "16-Os indicadores já foram aprovados <>";
                case 17:
                    return "17-ja foi solicitado a aprovação dos resultados <>";
                case 241:
                    return "241-Conversão de valores inválida<>";
                case 515:
                    return "515-Parametros inválido<>";
                case 547:
                    return "547-Violação de Constraint<>";
                default:
                    return MSG.ToString() +  " Erro não previsto <>";
            }
        }

    }
}
