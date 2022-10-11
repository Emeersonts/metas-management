using Metas.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Metas.Infrastructure.Interface
{
    public interface IRepositoryCiclo
    {
        Task<DataTable> RGetFindGetListProgressStatus(int CICLO);

        Task<DataTable> RGetFindGetListCiclo();
    }
}
