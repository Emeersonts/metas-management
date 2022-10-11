using Metas.Domain;
using Metas.Infrastructure.DTO;
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
        Task<DataTable> GetListIndicatorAdd(SearchcIndicadorDTO parameters);
        Task<DataTable> GetGoalsReport(int ciclo);
        Task<DataTable> GetListsolicitation(SearchcSolicitgacaoDTO parameters);
        Task<DataTable> GetFindColaborador(SearchcRepresentanteDTO parameters);
        Task<DataTable> Timeline();
        Task<int> SaveIndicador(Indicador parameters);
        Task<int> RemoveIndicador(int idindicador);
    }
}
