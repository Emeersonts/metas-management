using Metas.Domain;
using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Metas.Profile;

namespace Metas.DomainCore.Interface
{
    public interface IServiceColaborador
    {
        Task<DataTable> GetFindMeta(SearchcColaborador parameters, pkxd pkx);
        Task<DataTable> GetFindMetaResult(int ANOCICLO, pkxd pkx);
        Task<DataTable> GetFindAfastamento(int ciclo);
    }
}
