using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryRepresentante
    {
        Task<DataTable> RGetFindIndicatorSAP(SearchcRepresentanteDTO dto);
        Task<DataTable> RGetListIndicatorAdd(SearchcIndicadorDTO dto, pkxd pkx);
        Task<DataTable> RGetGoalsReport(int ciclo, pkxd pkx);
        Task<DataTable> RGetAddSIndicator(int ciclo);
        Task<DataTable> RGetListsolicitation(SearchcSolicitgacaoDTO dto, int anociclo);
        Task<DataTable> RGetFindColaborador(int PAGINA, int QTPAGINA);
        Task<DataTable> RTimeline();
        Task<int> RSaveIndicador(Indicador indicador);
        Task<int> RSendForApprovalIndicador(int ANOCICLO);
        Task<int> RSendResultForApproval(int ANOCICLO);
        Task<int> RRemoveIndicador(int IDINDICADOR);
    }
}
