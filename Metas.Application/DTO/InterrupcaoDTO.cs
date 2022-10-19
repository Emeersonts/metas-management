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
                return "01-Erro ao Remover idicador. Está em uso, não pode ser removido <>";
                case 2:
                    return "02-A soma geral do peso ultrapassa 100 % <>";
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
