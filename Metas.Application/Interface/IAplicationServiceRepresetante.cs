﻿using Metas.Application.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceRepresetante
    {
        Task<ForIndicadorSAP> OnGetFindIndicatorSAP(IndicadorDTO dto);
        Task<FormIndicadorDTO> OnGetListIndicatorAdd(EIndicadorAddDTO dto, pkxd pkx);
        Task<ForMetaRelatorioDTO> OnGetGoalsReport(int CICLO, pkxd pkx);
        Task<ForSIndicadorDTO> OnGetAddSIndicator(int CICLO, pkxd pkx);
        Task<ForSolicitacaoDTO> OnGetListsolicitation(ESolicitacaoDTO dto);
        Task<FormColaboradorDTO> OnGetFindColaborador(ColaboradorDTO dto, int qtpagina, pkxd pkx);
        Task<ForCronogramaDTO> OnTimeline();
        Task<int> OnSaveForm(GIndicadorDTTO dto);
        Task<int> OnSendForApprovalIndicador(int anociclo);
        Task<int> OnRemoveIndicador(int idindicador);

    }
}
