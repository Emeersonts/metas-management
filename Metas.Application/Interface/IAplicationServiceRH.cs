using Metas.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Application.Interface
{
    public interface IAplicationServiceRH
    {
        Task<ForDropGestorDTO> onGetListGestor();
        Task<FormCelulaTrabalhoDTO> onGetListCelula(int IDREPRESENTANTE);
        Task<ForMetaRelatorioDTO> onGetMetaSimulate(int anocilco, int idcelulatrabalho, int mes);
        Task<RepresentanteDTO> onGetVerifyRepresentantative(int idcelulatrabalho);
        Task<FormGestorStatusDTO> onGetMetaMmanagerStatus(int ANOCICLO, int PAGINA, int QTPPAGINA, string BUSCA);
        Task<FormDropColaboradorDTO> onDropCollaborator();
        Task<FormDropColaboradorDTO> onDropEqipCollaborator(int idcelulatrabalho);
    }
}
