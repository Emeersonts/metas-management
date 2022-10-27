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
    public interface IServiceGestor
    {
        Task<DataTable> GetGoalsReport(int ciclo);
        Task<DataTable> VializeTeam(int ciclo);
        Task<DataTable> GetFormTtype(int ciclo);
        Task<int> PutSaveFormEditType(TipoEdicaoFormulario parametrs);
        Task<DataTable> GetFindMeta(SearchcColaborador parameters, pkxd pkx);
        Task<DataTable> GetFindMetaResult(int ANOCICLO, int IDCELULATRABALHO, pkxd pkx);
    }
}
