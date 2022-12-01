using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Metas.Domain;
using Metas.Infrastructure.DTO;
using Metas.Profile;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryColaborador
    {
        Task<DataTable> RGetFindMeta(SearchcColaborador dto, int PRTIPO);
        Task<DataTable> RGetFindMetaResult(int ANOCICLO, pkxd pkx);
        Task<DataTable> RGetFindAfastamento(int ciclo);

    }
}
