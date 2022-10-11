using Metas.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceUser
    {
        Task<LisTutorialDTO> OnGetTutorialByUser();
        Task<LisTutorialDTO> OnGetGetCulture();
        Task<ListNotificacaoDTO> OnGetUserNotification();
        Task OnDeactiveTutorial(TutorialUsuarioDTO dto);
        Task<ListFrequenciaDTO> OnGetListFrequency();
        Task<ListUnidadeMedidaDTO> OnGetListMeasure();
    }
}
