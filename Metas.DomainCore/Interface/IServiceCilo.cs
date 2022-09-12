using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.DomainCore.Interface
{
    public interface IServiceCilo
    {
        Task<DataTable> GetFindGetListProgressStatus(SearchcColaborador parameters);
        Task<DataTable> GetFindGetListCiclo();
    }
}
