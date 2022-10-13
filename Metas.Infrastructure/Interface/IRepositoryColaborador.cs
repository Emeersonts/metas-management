using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Metas.Domain;
using Metas.Infrastructure.DTO;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryColaborador
    {
        Task<DataTable> RGetFindMeta(SearchcColaborador dto);
        Task<DataTable> RGetFindMetaResult(int ANOCICLO);
        Task<DataTable> RGetFindAfastamento(int ciclo);

    }
}
