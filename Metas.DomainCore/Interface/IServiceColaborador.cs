using Metas.Domain;
using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Metas.DomainCore.Interface
{
    public interface IServiceColaborador
    {
        Task<DataTable> GetFindMeta(SearchcColaborador parameters);
        Task<DataTable> GetFindMetaResult(SearchcColaborador parameters);
        Task<DataTable> GetFindAfastamento(SearchcColaborador parameters);
    }
}
