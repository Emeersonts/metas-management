﻿using System;
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
                    return "02-A soma geral do peso ultrapassa 100 % <>";
                case 3:
                    return "03-São seis metas no máximo cadastras por OU <>";
                case 4:
                    return "04-O indicador EBTIDA não pode ser removido <>";
                case 515:
                    return "515-Parametros inválidos<>";
                case 547:
                    return "547-Violação de Constraint<>";
                default:
                    return "Erro não previsto <>";
            }
        }

    }
}
