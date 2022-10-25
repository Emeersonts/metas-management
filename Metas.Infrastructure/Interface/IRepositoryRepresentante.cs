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
        Task<DataTable> RGetAddSIndicator(int ciclo, pkxd pkx);
        Task<DataTable> RGetListsolicitation(SearchcSolicitgacaoDTO dto);
        Task<DataTable> RGetFindColaborador(SearchcRepresentanteDTO dto, pkxd pkx);
        Task<DataTable> RTimeline();
        Task<int> RSaveIndicador(Indicador indicador);
        Task<int> RSendForApprovalIndicador(int ANOCICLO);
        Task<int> RRemoveIndicador(int IDINDICADOR);
    }
}
