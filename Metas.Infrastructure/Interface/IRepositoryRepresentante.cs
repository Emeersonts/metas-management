using Metas.Domain;
using Metas.Infrastructure.DTO;
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
        Task<DataTable> RGetListIndicatorAdd(SearchcIndicadorDTO dto);
        Task<DataTable> RGetGoalsReport(int ciclo);
        Task<DataTable> RGetAddSIndicator(int ciclo);
        Task<DataTable> RGetListsolicitation(SearchcSolicitgacaoDTO dto);
        Task<DataTable> RGetFindColaborador(SearchcRepresentanteDTO dto);
        Task<DataTable> RTimeline();
        Task<int> RSaveIndicador(Indicador indicador);
        Task<int> RRemoveIndicador(int IDINDICADOR);
    }
}
