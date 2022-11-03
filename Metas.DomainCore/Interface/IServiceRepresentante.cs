using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Profile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceRepresentante
    {
        Task<DataTable> GetFindIndicatorSAP(SearchcRepresentanteDTO parameters);
        Task<DataTable> GetListIndicatorAdd(SearchcIndicadorDTO parameters, pkxd pkx);
        Task<DataTable> GetGoalsReport(int ciclo, pkxd pkx);
        Task<DataTable> GetAddSIndicator(int ciclo, pkxd pkx);
        Task<DataTable> GetListsolicitation(SearchcSolicitgacaoDTO parameters, int ANOCICLO);
        Task<DataTable> GetFindColaborador(int pagina,  int qtpagina);
        Task<DataTable> Timeline();
        Task<int> SaveIndicador(Indicador parameters);
        Task<int> SendForApprovalIndicador(int anociclo);

        Task<int> RemoveIndicador(int idindicador);
    }
}
